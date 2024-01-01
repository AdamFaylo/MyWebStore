using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class initialseed14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "Title",
                value: "trousers for man");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 31, 17, 21, 22, 479, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 17, 21, 22, 479, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 31, 15, 21, 22, 479, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 30, 15, 21, 22, 479, DateTimeKind.Utc).AddTicks(1892));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "Title",
                value: "trousers pink for man");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 31, 17, 19, 19, 692, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 17, 19, 19, 692, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 31, 15, 19, 19, 692, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 30, 15, 19, 19, 692, DateTimeKind.Utc).AddTicks(6899));
        }
    }
}
