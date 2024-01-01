using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.API.Migrations
{
    /// <inheritdoc />
    public partial class initialseed6 : Migration
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
                value: new DateTime(2023, 12, 27, 19, 33, 3, 762, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 26, 19, 33, 3, 762, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 27, 17, 33, 3, 762, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 26, 17, 33, 3, 762, DateTimeKind.Utc).AddTicks(4550));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LogoImage",
                keyColumn: "ID",
                keyValue: 1,
                column: "Logo",
                value: "https://logoipsum.com/artwork/323");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 27, 19, 31, 28, 593, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 26, 19, 31, 28, 593, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 27, 17, 31, 28, 593, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "ID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 26, 17, 31, 28, 593, DateTimeKind.Utc).AddTicks(3027));
        }
    }
}
