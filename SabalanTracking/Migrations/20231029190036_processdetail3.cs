using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class processdetail3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, " ", "خرید" },
                    { 2, " ", "فروش" },
                    { 3, " ", "دستگاه جوش التراسونیک" },
                    { 4, " ", "دستگاه برش التراسونیک پارچه" },
                    { 5, " ", "دستگاه تزریق شماره مهاباد" },
                    { 6, " ", "دستگاه تزریق شماره عباسی" },
                    { 7, " ", "دستگاه سیلر بسته بندی" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "", "", "عباسی", "" },
                    { 2, "", "", "پژمان", "" },
                    { 3, "", "", "مهندس عبدالله پور", "" },
                    { 4, "", "", "مسعود", "" },
                    { 5, "", "", "رضا", "" },
                    { 6, "", "", "اپراتور 1 عباسی", "" },
                    { 7, "", "", "اپراتور 2 عبداللهی", "" }
                });

            migrationBuilder.InsertData(
                table: "ProcessNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "خرید" },
                    { 2, "فروش" },
                    { 3, "برش پارچه" },
                    { 4, "تزریق پلاستیک" },
                    { 5, "جوش التراسونیک" },
                    { 6, "بسته بندی" }
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
                table: "Units",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "کیلوگرم" },
                    { 2, "عدد" },
                    { 3, "متر" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "CatId", "Name", "UnitId" },
                values: new object[,]
                {
                    { 1, 2, "فیلتر HME", 2 },
                    { 2, 2, "فیلتر VFE", 2 },
                    { 3, 2, "فیلتر اسپیرومتری", 2 },
                    { 4, 3, "فیلتر ویپک HME", 2 },
                    { 5, 3, "ویپک VFE", 2 },
                    { 6, 3, "ویپک اسپیرومتری", 2 },
                    { 7, 3, "بدنه فیلتر اچ ام ای بدون درپوش", 2 },
                    { 8, 3, "بدنه فیلتر اچ ام ای با درپوش", 2 },
                    { 9, 3, "درپوش", 2 },
                    { 10, 3, "بدنه فیلتر آنتی باکتریال با درپوش", 2 },
                    { 11, 3, "بدنه فیلتر آنتی باکتریال بدون درپوش", 2 },
                    { 12, 3, "بدنه فیلتر اسپیرومتری شماره 1", 2 },
                    { 13, 3, "بدنه فیلتر اسپیرومتری شماره 2", 2 },
                    { 14, 1, "پلی استایرن-PS", 1 },
                    { 15, 1, "پلی پروپیلن-PP", 1 },
                    { 16, 1, "PVC", 1 },
                    { 17, 1, "کاغذ جاذب رطوبت", 2 },
                    { 18, 1, "ملت بلون", 3 },
                    { 19, 1, "اسپان باند", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "ProcessNames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3);

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
        }
    }
}
