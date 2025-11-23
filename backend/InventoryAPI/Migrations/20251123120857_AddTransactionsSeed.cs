using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTransactionsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2100), new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2110), new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2110), new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2110), new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.InsertData(
                table: "StockTransactions",
                columns: new[] { "Id", "Notes", "PerformedBy", "ProductId", "Quantity", "Reference", "TransactionDate", "Type" },
                values: new object[,]
                {
                    { 1, null, "John Doe", 1, 50, "PO-001", new DateTime(2025, 11, 13, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2120), 0 },
                    { 2, null, "Jane Smith", 1, 10, "SO-001", new DateTime(2025, 11, 18, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2130), 1 },
                    { 3, null, "John Doe", 2, 15, "PO-002", new DateTime(2025, 11, 16, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2130), 0 },
                    { 4, null, "Jane Smith", 3, 25, "SO-002", new DateTime(2025, 11, 21, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2130), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2030));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3070), new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3080), new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3080), new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3090), new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 11, 34, 0, 198, DateTimeKind.Utc).AddTicks(3020));
        }
    }
}
