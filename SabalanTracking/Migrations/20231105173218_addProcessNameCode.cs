using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class addProcessNameCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ProcessNames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "F");

            migrationBuilder.UpdateData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "F");

            migrationBuilder.UpdateData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "F");

            migrationBuilder.UpdateData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "F");

            migrationBuilder.UpdateData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 5,
                column: "Code",
                value: "F");

            migrationBuilder.UpdateData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 6,
                column: "Code",
                value: "F");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "ProcessNames");
        }
    }
}
