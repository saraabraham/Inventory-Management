using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialAzureMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    MinimumStock = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerformedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockTransactions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "ContactPerson", "CreatedAt", "Email", "IsActive", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Stockholm, Sweden", "Erik Larsson", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4820), "erik@scandi.com", true, "Scandinavian Furniture Co.", "+46-123-456" },
                    { 2, "Gdansk, Poland", "Anna Kowalski", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4830), "anna@baltic.com", true, "Baltic Wood Supplies", "+48-987-654" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "ImageUrl", "IsActive", "Location", "MinimumStock", "Name", "Price", "SKU", "StockQuantity", "SupplierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Storage", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4900), "Adjustable shelves for customized storage", "https://images.unsplash.com/photo-1594620302200-9a762244a156?w=400&h=400&fit=crop", true, "Warehouse A-1", 20, "BILLY Bookcase", 79.99m, "BILLY-001", 150, 1, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4900) },
                    { 2, "Furniture", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4910), "3-seat sofa with removable washable cover", "https://images.unsplash.com/photo-1555041469-a586c61ea9bc?w=400&h=400&fit=crop", true, "Warehouse B-3", 5, "EKTORP Sofa", 599.99m, "EKTORP-001", 25, 1, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4910) },
                    { 3, "Tables", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4920), "Easy to assemble side table", "https://images.unsplash.com/photo-1617097900219-2d6c81ecb60f?w=400&h=400&fit=crop", true, "Warehouse A-2", 30, "LACK Coffee Table", 49.99m, "LACK-001", 200, 2, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4920) },
                    { 4, "Bedroom", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4920), "Queen size bed frame with storage boxes", "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?w=400&h=400&fit=crop", true, "Warehouse C-1", 10, "MALM Bed Frame", 299.99m, "MALM-001", 15, 2, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4920) },
                    { 5, "Storage", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4920), "4x4 shelving unit, perfect for storage boxes", "https://images.unsplash.com/photo-1595428774223-ef52624120d2?w=400&h=400&fit=crop", true, "Warehouse A-1", 15, "KALLAX Shelf Unit", 129.99m, "KALLAX-001", 80, 1, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4920) },
                    { 6, "Furniture", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4920), "Comfortable armchair with bent wood frame", "https://images.unsplash.com/photo-1567538096630-e0c55bd6374c?w=400&h=400&fit=crop", true, "Warehouse B-2", 8, "POÄNG Armchair", 149.99m, "POANG-001", 45, 1, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4920) },
                    { 7, "Bedroom", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930), "8-drawer dresser in solid wood", "https://images.unsplash.com/photo-1558998966-079c4dbe6fd9?w=400&h=400&fit=crop", true, "Warehouse C-2", 5, "HEMNES Dresser", 399.99m, "HEMNES-001", 20, 2, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930) },
                    { 8, "Tables", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930), "Ash veneer dining table, seats 4-6 people", "https://images.unsplash.com/photo-1617806118233-18e1de247200?w=400&h=400&fit=crop", true, "Warehouse A-3", 8, "LISABO Dining Table", 279.99m, "LISABO-001", 30, 2, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930) },
                    { 9, "Lighting", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930), "Adjustable floor lamp, perfect for reading", "https://images.unsplash.com/photo-1513506003901-1e6a229e2d15?w=400&h=400&fit=crop", true, "Warehouse B-1", 15, "RANARP Floor Lamp", 89.99m, "RANARP-001", 60, 1, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930) },
                    { 10, "Kitchen", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930), "5-piece stainless steel cookware set", "https://images.unsplash.com/photo-1584990347449-39e4e37260d9?w=400&h=400&fit=crop", true, "Warehouse D-1", 10, "VARDAGEN Cookware Set", 199.99m, "VARDAGEN-001", 40, 1, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930) },
                    { 11, "Bedroom", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930), "Pine wood nightstand with 2 drawers", "https://images.unsplash.com/photo-1519710164239-da123dc03ef4?w=400&h=400&fit=crop", true, "Warehouse C-1", 12, "TARVA Nightstand", 69.99m, "TARVA-001", 55, 2, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4930) },
                    { 12, "Furniture", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4940), "5-seat corner sofa with chaise", "https://images.unsplash.com/photo-1550581190-9c1c48d21d6c?w=400&h=400&fit=crop", true, "Warehouse B-3", 3, "VIMLE Corner Sofa", 1299.99m, "VIMLE-001", 8, 1, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4940) },
                    { 13, "Storage", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4940), "Utility cart with wheels, perfect for kitchen or office", "https://images.unsplash.com/photo-1588471980726-8346cb477a33?w=400&h=400&fit=crop", true, "Warehouse A-2", 25, "RÅSKOG Cart", 39.99m, "RASKOG-001", 120, 1, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4940) },
                    { 14, "Decor", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4940), "Large walnut veneer framed mirror", "https://images.unsplash.com/photo-1618220179428-22790b461013?w=400&h=400&fit=crop", true, "Warehouse D-2", 5, "STOCKHOLM Mirror", 249.99m, "STOCKHOLM-001", 18, 2, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4940) },
                    { 15, "Storage", new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4940), "Industrial style TV bench with metal frame", "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?w=400&h=400&fit=crop", true, "Warehouse A-3", 8, "FJÄLLBO TV Unit", 179.99m, "FJALLBO-001", 35, 2, new DateTime(2025, 11, 23, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4940) }
                });

            migrationBuilder.InsertData(
                table: "StockTransactions",
                columns: new[] { "Id", "Notes", "PerformedBy", "ProductId", "Quantity", "Reference", "TransactionDate", "Type" },
                values: new object[,]
                {
                    { 1, null, "John Doe", 1, 50, "PO-001", new DateTime(2025, 11, 13, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4970), 0 },
                    { 2, null, "Jane Smith", 1, 10, "SO-001", new DateTime(2025, 11, 18, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4980), 1 },
                    { 3, null, "John Doe", 2, 15, "PO-002", new DateTime(2025, 11, 16, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4980), 0 },
                    { 4, null, "Jane Smith", 3, 25, "SO-002", new DateTime(2025, 11, 21, 14, 30, 8, 659, DateTimeKind.Utc).AddTicks(4980), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SKU",
                table: "Products",
                column: "SKU",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransactions_ProductId",
                table: "StockTransactions",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockTransactions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
