using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTrackerWebApp.Migrations
{
    public partial class SeedInitalDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "Amount",
                value: 40m);

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ItemId", "Amount", "ItemName", "PersonId" },
                values: new object[,]
                {
                    { 4, 20m, "Umbrella", 2 },
                    { 5, 10m, "Book", 2 },
                    { 6, 1000m, "Computer", 3 },
                    { 7, 10m, "Hat", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "Amount",
                value: 20m);
        }
    }
}
