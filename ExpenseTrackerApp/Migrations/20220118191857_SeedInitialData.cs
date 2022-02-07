using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTrackerWebApp.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "FirstName", "LastName" },
                values: new object[] { 1, "Francesco", "Tagliatti" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "FirstName", "LastName" },
                values: new object[] { 2, "Rachael", "Kapple" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "FirstName", "LastName" },
                values: new object[] { 3, "Mark", "Flynn" });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ItemId", "Amount", "ItemName", "PersonId" },
                values: new object[] { 1, 10000m, "Car", 1 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ItemId", "Amount", "ItemName", "PersonId" },
                values: new object[] { 2, 250m, "Watch", 1 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ItemId", "Amount", "ItemName", "PersonId" },
                values: new object[] { 3, 20m, "Shoes", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1);
        }
    }
}
