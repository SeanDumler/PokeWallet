using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeWallet.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeededBudgets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "OwnerId",
                value: "Scizor");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnerId",
                value: "Scizor");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "OwnerId",
                value: "Scizor");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "OwnerId",
                value: "Scizor");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "OwnerId",
                value: "Scizor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "OwnerId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnerId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "OwnerId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "OwnerId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "OwnerId",
                value: "");
        }
    }
}
