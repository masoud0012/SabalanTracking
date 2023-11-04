using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class AddFormullaToProces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormullaId",
                table: "Processes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processes_FormullaId",
                table: "Processes",
                column: "FormullaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processes_Formulas_FormullaId",
                table: "Processes",
                column: "FormullaId",
                principalTable: "Formulas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processes_Formulas_FormullaId",
                table: "Processes");

            migrationBuilder.DropIndex(
                name: "IX_Processes_FormullaId",
                table: "Processes");

            migrationBuilder.DropColumn(
                name: "FormullaId",
                table: "Processes");
        }
    }
}
