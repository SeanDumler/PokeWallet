using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokeWallet.Data.Migrations
{
    /// <inheritdoc />
    public partial class added_seeded_budgets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "AvailableFunds", "Month", "OwnerId", "Year" },
                values: new object[,]
                {
                    { 1, 0, "May", "", 2023 },
                    { 2, 0, "June", "", 2023 },
                    { 3, 0, "July", "", 2023 },
                    { 4, 0, "August", "", 2023 },
                    { 5, 0, "September", "", 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
