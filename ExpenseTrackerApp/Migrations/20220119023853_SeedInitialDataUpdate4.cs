using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTrackerWebApp.Migrations
{
    public partial class SeedInitialDataUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Expenses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 38, 53, 109, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 38, 53, 111, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 38, 53, 111, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 38, 53, 111, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 38, 53, 111, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 38, 53, 111, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 38, 53, 111, DateTimeKind.Local).AddTicks(2301));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Expenses",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 33, 38, 0, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 33, 38, 2, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 33, 38, 2, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 33, 38, 2, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 33, 38, 2, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 33, 38, 2, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2022, 1, 18, 18, 33, 38, 2, DateTimeKind.Local).AddTicks(5917));
        }
    }
}
