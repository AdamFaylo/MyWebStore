using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class initialseed13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: "https://i.imgur.com/kFFe4rc.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageURL",
                value: "https://i.imgur.com/FSzo30R.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageURL",
                value: "https://i.imgur.com/OrJ3uxz.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/FMyHAER.png", "T-SHIRTS for man" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/1vvkkun.png", "T-SHIRTS for man" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/Q2Omp1q.png", "T-SHIRTS for man" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 7,
                column: "Title",
                value: "trousers for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 8,
                column: "Title",
                value: "trousers for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "Title",
                value: "trousers pink for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 10,
                column: "Title",
                value: "acc for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 11,
                column: "Title",
                value: "acc for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 12,
                column: "Title",
                value: "acc for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 13,
                column: "ImageURL",
                value: "https://i.imgur.com/HpT7xCj.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 14,
                column: "ImageURL",
                value: "https://i.imgur.com/48fArMF.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 15,
                column: "ImageURL",
                value: "https://i.imgur.com/SuXlbYo.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 16,
                column: "ImageURL",
                value: "https://i.imgur.com/nA84c5Y.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 17,
                column: "ImageURL",
                value: "https://i.imgur.com/KLI84On.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 18,
                column: "ImageURL",
                value: "https://i.imgur.com/N3Hw655.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 25,
                column: "ImageURL",
                value: "https://i.imgur.com/wylMcYn.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 26,
                column: "ImageURL",
                value: "https://i.imgur.com/ydaUz58.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 27,
                column: "ImageURL",
                value: "https://i.imgur.com/WeiJljO.png");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/pBhxbGl.png", "T-SHIRT for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/UJeZ4jX.png", "T-SHIRT for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/pBhxbGl.png", "T-SHIRT for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/5sEKFeH.png", "acc for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/iaP5xXB.png", "acc for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/BxlFtRr.png", "acc for kids" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: "https://i.imgur.com/x3U6jKx.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageURL",
                value: "https://i.imgur.com/LnQGteX.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageURL",
                value: "https://i.imgur.com/v3SN2Vo.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/CVmmzhU.jpg", "shoes for man" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/LGfzcug.jpg", "shoes for man" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/P3XGF8p.jpg", "shoes for man" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 7,
                column: "Title",
                value: "shoes pastel color for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 8,
                column: "Title",
                value: "shoes pink for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "Title",
                value: "shoes pink for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 10,
                column: "Title",
                value: "shoes for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 11,
                column: "Title",
                value: "shoes for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 12,
                column: "Title",
                value: "shoes for man");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 13,
                column: "ImageURL",
                value: "https://i.imgur.com/A4b2kSN.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 14,
                column: "ImageURL",
                value: "https://i.imgur.com/z1zF5F0.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 15,
                column: "ImageURL",
                value: "https://i.imgur.com/GYkO0dn.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 16,
                column: "ImageURL",
                value: "https://i.imgur.com/yKIuCZN.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 17,
                column: "ImageURL",
                value: "https://i.imgur.com/rgMPyCg.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 18,
                column: "ImageURL",
                value: "https://i.imgur.com/IkeJGoS.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 25,
                column: "ImageURL",
                value: "https://i.imgur.com/mtgc2Kl.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 26,
                column: "ImageURL",
                value: "https://i.imgur.com/IMMWY3v.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 27,
                column: "ImageURL",
                value: "https://i.imgur.com/bFZSTKa.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/VXSGhtq.jpg", "shoes for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/ugyS15L.jpg", "shoes for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/FcuvIH4.jpg", "shoes for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/hFBMhA1.jpg", "shoes for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/OeC6gqG.jpg", "shoes for kids" });

            migrationBuilder.UpdateData(
                table: "GalleryImage",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "ImageURL", "Title" },
                values: new object[] { "https://i.imgur.com/P0vlF79.jpg", "shoes for kids" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 31, 17, 17, 53, 761, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 17, 17, 53, 761, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 31, 15, 17, 53, 761, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 30, 15, 17, 53, 761, DateTimeKind.Utc).AddTicks(1553));
        }
    }
}
