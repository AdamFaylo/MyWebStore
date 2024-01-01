using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class initialseed15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 23,
                column: "Title",
                value: "acc for woman");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 24,
                column: "Title",
                value: "acc for woman");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 31, 17, 24, 8, 813, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 17, 24, 8, 813, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 31, 15, 24, 8, 813, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 30, 15, 24, 8, 813, DateTimeKind.Utc).AddTicks(1605));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 23,
                column: "Title",
                value: "acc pink for woman");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 24,
                column: "Title",
                value: "acc pink for woman");

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
    }
}
