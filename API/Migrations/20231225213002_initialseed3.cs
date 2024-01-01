using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class initialseed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LogoImage",
                keyColumn: "ID",
                keyValue: 1,
                column: "Logo",
                value: "https://i.imgur.com/6jdrLVk.png");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 24, 23, 30, 2, 130, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 23, 23, 30, 2, 130, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 24, 21, 30, 2, 130, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 23, 21, 30, 2, 130, DateTimeKind.Utc).AddTicks(2438));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LogoImage",
                keyColumn: "ID",
                keyValue: 1,
                column: "Logo",
                value: "https://i.imgur.com/VcU01l9.png");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 24, 7, 30, 1, 248, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 23, 7, 30, 1, 248, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 24, 5, 30, 1, 248, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 23, 5, 30, 1, 248, DateTimeKind.Utc).AddTicks(1312));
        }
    }
}
