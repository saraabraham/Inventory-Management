import React, { useEffect, useState } from 'react';
import { Product, productService } from '../services/api';
import { Package, AlertTriangle, TrendingUp, DollarSign } from 'lucide-react';
import { PieChart, Pie, BarChart, Bar, Cell, XAxis, YAxis, CartesianGrid, Tooltip, ResponsiveContainer } from 'recharts';

const COLORS = ['#0051BA', '#FFDB00', '#FF6B6B', '#4ECDC4', '#45B7D1', '#96CEB4'];

const Dashboard: React.FC = () => {
    const [products, setProducts] = useState<Product[]>([]);
    const [lowStockProducts, setLowStockProducts] = useState<Product[]>([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        loadData();
    }, []);

    const loadData = async () => {
        try {
            const [productsRes, lowStockRes] = await Promise.all([
                productService.getAll(),
                productService.getLowStock(),
            ]);
            setProducts(productsRes.data);
            setLowStockProducts(lowStockRes.data);
        } catch (error) {
            console.error('Error loading data:', error);
        } finally {
            setLoading(false);
        }
    };

    const totalValue = products.reduce((sum, p) => sum + (p.price * p.stockQuantity), 0);
    const totalItems = products.reduce((sum, p) => sum + p.stockQuantity, 0);

    if (loading) {
        return <div className="flex justify-center items-center h-64">Loading...</div>;
    }

    return (
        <div className="p-6">
            <h1 className="text-3xl font-bold text-ikea-blue mb-6">Inventory Dashboard</h1>

            {/* Stats Cards */}
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6 mb-8">
                <div className="bg-white rounded-lg shadow p-6">
                    <div className="flex items-center justify-between">
                        <div>
                            <p className="text-gray-500 text-sm">Total Products</p>
                            <p className="text-3xl font-bold text-ikea-blue">{products.length}</p>
                        </div>
                        <Package className="w-12 h-12 text-ikea-blue opacity-20" />
                    </div>
                </div>


                <div className="bg-white rounded-lg shadow p-6">
                    <div className="flex items-center justify-between">
                        <div>
                            <p className="text-gray-500 text-sm">Total Items</p>
                            <p className="text-3xl font-bold text-ikea-blue">{totalItems}</p>
                        </div>
                        <TrendingUp className="w-12 h-12 text-ikea-blue opacity-20" />
                    </div>
                </div>

                <div className="bg-white rounded-lg shadow p-6">
                    <div className="flex items-center justify-between">
                        <div>
                            <p className="text-gray-500 text-sm">Inventory Value</p>
                            <p className="text-3xl font-bold text-ikea-blue">${totalValue.toFixed(2)}</p>
                        </div>
                        <DollarSign className="w-12 h-12 text-ikea-blue opacity-20" />
                    </div>
                </div>

                <div className="bg-white rounded-lg shadow p-6">
                    <div className="flex items-center justify-between">
                        <div>
                            <p className="text-gray-500 text-sm">Low Stock Items</p>
                            <p className="text-3xl font-bold text-red-600">{lowStockProducts.length}</p>
                        </div>
                        <AlertTriangle className="w-12 h-12 text-red-600 opacity-20" />
                    </div>
                </div>
            </div>

            {/* Charts Section */}
            <div className="grid grid-cols-1 lg:grid-cols-2 gap-6 mb-6">
                {/* Stock Value by Category */}
                <div className="bg-white rounded-lg shadow p-6">
                    <h2 className="text-xl font-semibold text-ikea-blue mb-4">
                        Inventory Value by Category
                    </h2>
                    <ResponsiveContainer width="100%" height={300}>
                        <PieChart>
                            <Pie
                                data={Object.entries(
                                    products.reduce((acc, product) => {
                                        const value = product.price * product.stockQuantity;
                                        acc[product.category] = (acc[product.category] || 0) + value;
                                        return acc;
                                    }, {} as Record<string, number>)
                                ).map(([name, value]) => ({ name, value }))}
                                cx="50%"
                                cy="50%"
                                labelLine={false}
                                label={({ name, percent }) => `${name}: ${percent ? (percent * 100).toFixed(0) : 0}%`}
                                outerRadius={80}
                                fill="#8884d8"
                                dataKey="value"
                            >
                                {Object.keys(
                                    products.reduce((acc, product) => {
                                        acc[product.category] = true;
                                        return acc;
                                    }, {} as Record<string, boolean>)
                                ).map((entry, index) => (
                                    <Cell key={`cell-${index}`} fill={COLORS[index % COLORS.length]} />
                                ))}
                            </Pie>
                            <Tooltip formatter={(value: number) => `$${value.toFixed(2)}`} />
                        </PieChart>
                    </ResponsiveContainer>
                </div>

                {/* Top Products by Value */}
                <div className="bg-white rounded-lg shadow p-6">
                    <h2 className="text-xl font-semibold text-ikea-blue mb-4">
                        Top 5 Products by Value
                    </h2>
                    <ResponsiveContainer width="100%" height={300}>
                        <BarChart
                            data={products
                                .map(p => ({
                                    name: p.name.length > 15 ? p.name.substring(0, 15) + '...' : p.name,
                                    value: p.price * p.stockQuantity
                                }))
                                .sort((a, b) => b.value - a.value)
                                .slice(0, 5)}
                        >
                            <CartesianGrid strokeDasharray="3 3" />
                            <XAxis dataKey="name" angle={-45} textAnchor="end" height={100} />
                            <YAxis />
                            <Tooltip formatter={(value: number) => `$${value.toFixed(2)}`} />
                            <Bar dataKey="value" fill="#0051BA" />
                        </BarChart>
                    </ResponsiveContainer>
                </div>
            </div>

            {/* Low Stock Alert */}
            {lowStockProducts.length > 0 && (
                <div className="bg-red-50 border-l-4 border-red-500 p-4 mb-6">
                    <div className="flex items-center">
                        <AlertTriangle className="w-6 h-6 text-red-600 mr-3" />
                        <div>
                            <h3 className="text-red-800 font-semibold">Low Stock Alert</h3>
                            <p className="text-red-700 text-sm">
                                {lowStockProducts.length} product(s) are running low on stock
                            </p>
                        </div>
                    </div>
                    <div className="mt-3">
                        {lowStockProducts.map(product => (
                            <div key={product.id} className="text-sm text-red-700 py-1">
                                • {product.name} - Only {product.stockQuantity} units left (Min: {product.minimumStock})
                            </div>
                        ))}
                    </div>
                </div>
            )}

            {/* Category Distribution */}
            <div className="bg-white rounded-lg shadow p-6">
                <h2 className="text-xl font-semibold text-ikea-blue mb-4">Products by Category</h2>
                <div className="space-y-3">
                    {Object.entries(
                        products.reduce((acc, product) => {
                            acc[product.category] = (acc[product.category] || 0) + 1;
                            return acc;
                        }, {} as Record<string, number>)
                    ).map(([category, count]) => (
                        <div key={category} className="flex items-center justify-between">
                            <span className="text-gray-700">{category}</span>
                            <div className="flex items-center">
                                <div className="w-32 bg-gray-200 rounded-full h-2 mr-3">
                                    <div
                                        className="bg-ikea-blue h-2 rounded-full"
                                        style={{ width: `${(count / products.length) * 100}%` }}
                                    ></div>
                                </div>
                                <span className="text-gray-600 font-semibold w-8">{count}</span>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
};

export default Dashboard;