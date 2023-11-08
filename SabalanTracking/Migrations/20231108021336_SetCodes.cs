using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class SetCodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryCode",
                table: "ProductCats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaterialCode",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "MaterialCode",
                value: "PR00.0000");

            migrationBuilder.UpdateData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryCode",
                value: "C00.0000");

            migrationBuilder.UpdateData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryCode",
                value: "C00.0000");

            migrationBuilder.UpdateData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryCode",
                value: "C00.0000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryCode",
                table: "ProductCats");

            migrationBuilder.DropColumn(
                name: "MaterialCode",
                table: "Materials");
        }
    }
}
