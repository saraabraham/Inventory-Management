using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8650), null, new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660), null, new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660), null, new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660), null, new DateTime(2025, 11, 23, 12, 29, 54, 201, DateTimeKind.Utc).AddTicks(8660) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

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

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 13, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 18, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 16, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "StockTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2025, 11, 21, 12, 8, 57, 323, DateTimeKind.Utc).AddTicks(2130));

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
    }
}
