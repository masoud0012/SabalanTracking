using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class AddUnitForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Materials_UnitId",
                table: "Materials",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Units_UnitId",
                table: "Materials",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Units_UnitId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_UnitId",
                table: "Materials");
        }
    }
}
