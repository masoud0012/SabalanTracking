using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class dropAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Materials");

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Materials");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, " ", "دستگاه جوش التراسونیک" },
                    { 2, " ", "دستگاه برش التراسونیک پارچه" },
                    { 3, " ", "دستگاه تزریق شماره 1" },
                    { 4, " ", "دستگاه تزریق شماره 2" },
                    { 5, " ", "دستگاه تزریق شماره 3" },
                    { 6, " ", "دستگاه تزریق شماره 4" },
                    { 7, " ", "دستگاه تزریق شماره عباسی" },
                    { 8, " ", "دستگاه سیلر بسته بندی" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "عباسی" },
                    { 2, "پژمان" },
                    { 3, "مهندس عبدالله پور" },
                    { 4, "مسعود" },
                    { 5, "رضا" },
                    { 6, "اپراتور 1 عباسی" },
                    { 7, "اپراتور 2 عبداللهی" }
                });

            migrationBuilder.InsertData(
                table: "ProcessNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "برش پارچه" },
                    { 2, "تزریق پلاستیک" },
                    { 3, "جوش التراسونیک" },
                    { 4, "بسته بندی" },
                    { 5, "خرید" }
                });

            migrationBuilder.InsertData(
                table: "ProductCats",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { 1, "RawMaterial" },
                    { 2, "FinalProduct" },
                    { 3, "Semi Final Prodct" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "CatId", "Name", "Unit" },
                values: new object[,]
                {
                    { 1, 2, "فیلتر HME", "عدد" },
                    { 2, 2, "فیلتر VFE", "عدد" },
                    { 3, 2, "فیلتر اسپیرومتری", "عدد" },
                    { 4, 3, "فیلتر ویپک HME", "عدد" },
                    { 5, 3, "ویپک VFE", "عدد" },
                    { 6, 3, "ویپک اسپیرومتری", "عدد" },
                    { 7, 3, "بدنه فیلتر HME بدون درپوش", "عدد" },
                    { 8, 3, "بدنه فیلتر HME با درپوش", "عدد" },
                    { 9, 3, "درپوش", "عدد" },
                    { 10, 3, "بدنه فیلتر آنتی باکتریال با درپوش", "عدد" },
                    { 11, 3, "بدنه فیلتر آنتی باکتریال بدون درپوش", "عدد" },
                    { 12, 3, "بدنه فیلتر اسپیرومتری شماره 1", "عدد" },
                    { 13, 3, "بدنه فیلتر اسپیرومتری شماره 2", "عدد" },
                    { 14, 1, "پلی استایرن-PS", "کیلوگرم" },
                    { 15, 1, "پلی پروپیلن-PP", "کیلوگرم" },
                    { 16, 1, "PVC", "کیلوگرم" },
                    { 17, 1, "کاغذ جاذب رطوبت", "عدد" },
                    { 18, 1, "ملت بلون", "کیلوگرم" },
                    { 19, 1, "اسپان باند", "کیلوگرم" }
                });
        }
    }
}
