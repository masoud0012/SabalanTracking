using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class Details : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "ProcessDetails");

            migrationBuilder.RenameColumn(
                name: "ProductSN",
                table: "ProcessDetails",
                newName: "ProcessID_SN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProcessID_SN",
                table: "ProcessDetails",
                newName: "ProductSN");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "ProcessDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
