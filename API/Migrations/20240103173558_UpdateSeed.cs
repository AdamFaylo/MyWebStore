using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 2, 19, 35, 57, 975, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 1, 1, 19, 35, 57, 975, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 2, 17, 35, 57, 975, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 1, 17, 35, 57, 975, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 6,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 7,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 8,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 9,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 10,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 11,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 12,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 13,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 14,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 15,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 16,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 17,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 18,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 19,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 20,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 21,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 22,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 23,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 24,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 25,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 26,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 27,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 28,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 29,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 30,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 31,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 32,
                column: "CategoryID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 33,
                column: "CategoryID",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 2, 19, 29, 14, 967, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 1, 1, 19, 29, 14, 967, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 2, 17, 29, 14, 967, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 1, 17, 29, 14, 967, DateTimeKind.Utc).AddTicks(4646));
        }
    }
}
