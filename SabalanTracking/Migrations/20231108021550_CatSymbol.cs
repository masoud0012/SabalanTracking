using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class CatSymbol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "ProductCats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Symbol",
                value: "S");

            migrationBuilder.UpdateData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Symbol",
                value: "S");

            migrationBuilder.UpdateData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Symbol",
                value: "S");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "ProductCats");
        }
    }
}
