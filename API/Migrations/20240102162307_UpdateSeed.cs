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
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 10,
                column: "ImageURL",
                value: "https://i.imgur.com/2KSWpFs.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 11,
                column: "ImageURL",
                value: "https://i.imgur.com/yhlgVxL.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 22,
                column: "ImageURL",
                value: "https://i.imgur.com/THBDPax.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 23,
                column: "ImageURL",
                value: "https://i.imgur.com/vNPCxkh.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 24,
                column: "ImageURL",
                value: "https://i.imgur.com/Q3UjsjY.png");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 1, 18, 23, 6, 763, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 31, 18, 23, 6, 763, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 1, 16, 23, 6, 763, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 31, 16, 23, 6, 763, DateTimeKind.Utc).AddTicks(4740));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 10,
                column: "ImageURL",
                value: "https://i.imgur.com/qpalZ7J.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 11,
                column: "ImageURL",
                value: "https://i.imgur.com/Qd0hKEe.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 22,
                column: "ImageURL",
                value: "https://i.imgur.com/KuAG5Ae.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 23,
                column: "ImageURL",
                value: "https://i.imgur.com/5Mp82QF.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 24,
                column: "ImageURL",
                value: "https://i.imgur.com/VvOHI60.jpg");

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
    }
}
