using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 7,
                column: "ImageURL",
                value: "https://i.imgur.com/6HUpAq5.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 8,
                column: "ImageURL",
                value: "https://i.imgur.com/tpdPfHe.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "ImageURL",
                value: "https://i.imgur.com/LJnaKkR.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 10,
                column: "ImageURL",
                value: "https://i.imgur.com/yhlgVxL.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 11,
                column: "ImageURL",
                value: "https://i.imgur.com/f2TOHlO.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 12,
                column: "ImageURL",
                value: "https://i.imgur.com/fKIG06M.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 19,
                column: "ImageURL",
                value: "https://i.imgur.com/9Unyl2Q.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 20,
                column: "ImageURL",
                value: "https://i.imgur.com/UxLMIKE.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 21,
                column: "ImageURL",
                value: "https://i.imgur.com/XaXUJNl.png");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 1, 2, 10, 8, 55, 814, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 1, 1, 10, 8, 55, 814, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 2, 8, 8, 55, 814, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 1, 8, 8, 55, 814, DateTimeKind.Utc).AddTicks(2577));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 7,
                column: "ImageURL",
                value: "https://i.imgur.com/oPlSrbz.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 8,
                column: "ImageURL",
                value: "https://i.imgur.com/0oZ7MrE.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "ImageURL",
                value: "https://i.imgur.com/UczdMkv.jpg");

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
                keyValue: 12,
                column: "ImageURL",
                value: "https://i.imgur.com/vPXZfwu.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 19,
                column: "ImageURL",
                value: "https://i.imgur.com/NhR4kFB.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 20,
                column: "ImageURL",
                value: "https://i.imgur.com/4xStoKp.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 21,
                column: "ImageURL",
                value: "https://i.imgur.com/n3TMOZI.jpg");

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
    }
}
