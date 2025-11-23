using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductSeedDataWithImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5190), "Adjustable shelves for customized storage", "https://images.unsplash.com/photo-1594620302200-9a762244a156?w=400&h=400&fit=crop", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5190), "3-seat sofa with removable washable cover", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=400&h=400&fit=crop", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5190), "Easy to assemble side table", "https://images.unsplash.com/photo-1617097900219-2d6c81ecb60f?w=400&h=400&fit=crop", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200), "Queen size bed frame with storage boxes", "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?w=400&h=400&fit=crop", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "ImageUrl", "IsActive", "Location", "MinimumStock", "Name", "Price", "SKU", "StockQuantity", "SupplierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, "Storage", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200), "4x4 shelving unit, perfect for storage boxes", "https://images.unsplash.com/photo-1595428774223-ef52624120d2?w=400&h=400&fit=crop", true, "Warehouse A-1", 15, "KALLAX Shelf Unit", 129.99m, "KALLAX-001", 80, 1, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200) },
                    { 6, "Furniture", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200), "Comfortable armchair with bent wood frame", "https://images.unsplash.com/photo-1567538096630-e0c55bd6374c?w=400&h=400&fit=crop", true, "Warehouse B-2", 8, "POÄNG Armchair", 149.99m, "POANG-001", 45, 1, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200) },
                    { 7, "Bedroom", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200), "8-drawer dresser in solid wood", "https://images.unsplash.com/photo-1558998966-079c4dbe6fd9?w=400&h=400&fit=crop", true, "Warehouse C-2", 5, "HEMNES Dresser", 399.99m, "HEMNES-001", 20, 2, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200) },
                    { 8, "Tables", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200), "Ash veneer dining table, seats 4-6 people", "https://images.unsplash.com/photo-1617806118233-18e1de247200?w=400&h=400&fit=crop", true, "Warehouse A-3", 8, "LISABO Dining Table", 279.99m, "LISABO-001", 30, 2, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5200) },
                    { 9, "Lighting", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210), "Adjustable floor lamp, perfect for reading", "https://images.unsplash.com/photo-1513506003901-1e6a229e2d15?w=400&h=400&fit=crop", true, "Warehouse B-1", 15, "RANARP Floor Lamp", 89.99m, "RANARP-001", 60, 1, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210) },
                    { 10, "Kitchen", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210), "5-piece stainless steel cookware set", "https://images.unsplash.com/photo-1584990347449-39e4e37260d9?w=400&h=400&fit=crop", true, "Warehouse D-1", 10, "VARDAGEN Cookware Set", 199.99m, "VARDAGEN-001", 40, 1, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210) },
                    { 11, "Bedroom", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210), "Pine wood nightstand with 2 drawers", "https://images.unsplash.com/photo-1519710164239-da123dc03ef4?w=400&h=400&fit=crop", true, "Warehouse C-1", 12, "TARVA Nightstand", 69.99m, "TARVA-001", 55, 2, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210) },
                    { 12, "Furniture", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210), "5-seat corner sofa with chaise", "https://images.unsplash.com/photo-1550581190-9c1c48d21d6c?w=400&h=400&fit=crop", true, "Warehouse B-3", 3, "VIMLE Corner Sofa", 1299.99m, "VIMLE-001", 8, 1, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210) },
                    { 13, "Storage", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210), "Utility cart with wheels, perfect for kitchen or office", "https://images.unsplash.com/photo-1588471980726-8346cb477a33?w=400&h=400&fit=crop", true, "Warehouse A-2", 25, "RÅSKOG Cart", 39.99m, "RASKOG-001", 120, 1, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210) },
                    { 14, "Decor", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210), "Large walnut veneer framed mirror", "https://images.unsplash.com/photo-1618220179428-22790b461013?w=400&h=400&fit=crop", true, "Warehouse D-2", 5, "STOCKHOLM Mirror", 249.99m, "STOCKHOLM-001", 18, 2, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5210) },
                    { 15, "Storage", new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5220), "Industrial style TV bench with metal frame", "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?w=400&h=400&fit=crop", true, "Warehouse A-3", 8, "FJÄLLBO TV Unit", 179.99m, "FJALLBO-001", 35, 2, new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5220) }
                });

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 13, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 18, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 16, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 21, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 12, 34, 26, 278, DateTimeKind.Utc).AddTicks(5100));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8650), "Adjustable shelves", null, new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660), "3-seat sofa with removable cover", null, new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660), "Easy to assemble", null, new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660), "Queen size with storage", null, new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 13, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 18, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 16, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 21, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8590));
        }
    }
}
