using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTrackerWebApp.Migrations
{
    public partial class SeedInitialDataUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
