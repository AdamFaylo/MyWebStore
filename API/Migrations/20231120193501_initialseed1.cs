using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class initialseed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Man");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Ladies");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 11, 19, 21, 35, 0, 700, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 11, 18, 21, 35, 0, 700, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 11, 19, 19, 35, 0, 700, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 11, 18, 19, 35, 0, 700, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "Password",
                value: "12346578");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                column: "Password",
                value: "87654321");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                column: "Password",
                value: "55555555");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "MAN");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "LADIES");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "KIDS");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 11, 19, 14, 1, 4, 585, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 11, 18, 14, 1, 4, 585, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 11, 19, 12, 1, 4, 585, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 11, 18, 12, 1, 4, 585, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "Password",
                value: "1324");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                column: "Password",
                value: "4321");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                column: "Password",
                value: "55555");
        }
    }
}
