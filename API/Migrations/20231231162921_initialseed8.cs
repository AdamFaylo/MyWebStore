using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class initialseed8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 18, 29, 20, 945, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 29, 18, 29, 20, 945, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 30, 16, 29, 20, 945, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 29, 16, 29, 20, 945, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 6,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 7,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 8,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 9,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 10,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 11,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 12,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 13,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 14,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 15,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 16,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 17,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 18,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 19,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 20,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 21,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 22,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 23,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 24,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 25,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 26,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 27,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 28,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 29,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 30,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 31,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 32,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 33,
                column: "Description",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing ");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EmailAddress", "Password" },
                values: new object[] { "Admin@gmail.com", "12345678" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                column: "EmailAddress",
                value: "User@gmail.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 30, 18, 20, 21, 558, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 29, 18, 20, 21, 558, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 30, 16, 20, 21, 558, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 29, 16, 20, 21, 558, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EmailAddress", "Password" },
                values: new object[] { "adam@gmail.com", "12346578" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                column: "EmailAddress",
                value: "eran@gmail.com");
        }
    }
}
