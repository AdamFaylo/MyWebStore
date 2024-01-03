using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class AddLogoInContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LogoImage",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Alt", "Logo" },
                values: new object[] { "Logo site", "https://i.imgur.com/t4hi8os.png" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 31, 19, 44, 57, 386, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 19, 44, 57, 386, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 31, 17, 44, 57, 386, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 30, 17, 44, 57, 386, DateTimeKind.Utc).AddTicks(5389));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LogoImage",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Alt", "Logo" },
                values: new object[] { "Logo vanes site", "https://i.imgur.com/6jdrLVk.png" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 31, 18, 7, 51, 954, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 18, 7, 51, 954, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 31, 16, 7, 51, 954, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 30, 16, 7, 51, 954, DateTimeKind.Utc).AddTicks(6677));
        }
    }
}
