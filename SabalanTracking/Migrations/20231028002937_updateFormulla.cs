using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class updateFormulla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Formulas_ProductId",
                table: "Formulas",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formulas_Materials_ProductId",
                table: "Formulas",
                column: "ProductId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formulas_Materials_ProductId",
                table: "Formulas");

            migrationBuilder.DropIndex(
                name: "IX_Formulas_ProductId",
                table: "Formulas");
        }
    }
}
