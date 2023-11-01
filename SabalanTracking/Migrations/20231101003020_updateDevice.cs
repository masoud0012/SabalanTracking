using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class updateDevice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "quantity",
                table: "FormullaDetails",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DeviceSN",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeviceSN",
                value: "SN");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeviceSN",
                value: "SN");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeviceSN",
                value: "SN");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeviceSN",
                value: "SN");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeviceSN",
                value: "SN");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeviceSN",
                value: "SN");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7,
                column: "DeviceSN",
                value: "SN");

            migrationBuilder.CreateIndex(
                name: "IX_FormullaDetails_MaterialId",
                table: "FormullaDetails",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormullaDetails_Materials_MaterialId",
                table: "FormullaDetails",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormullaDetails_Materials_MaterialId",
                table: "FormullaDetails");

            migrationBuilder.DropIndex(
                name: "IX_FormullaDetails_MaterialId",
                table: "FormullaDetails");

            migrationBuilder.DropColumn(
                name: "DeviceSN",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "FormullaDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
