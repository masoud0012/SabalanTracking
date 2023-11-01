using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class keyInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_ProductCats_CatId",
                        column: x => x.CatId,
                        principalTable: "ProductCats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessNameId = table.Column<int>(type: "int", nullable: false),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processes_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processes_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processes_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processes_ProcessNames_ProcessNameId",
                        column: x => x.ProcessNameId,
                        principalTable: "ProcessNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    ProductSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QntyPerPc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessDetails_Processes_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CatId",
                table: "Materials",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessDetails_ProcessId",
                table: "ProcessDetails",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_DeviceId",
                table: "Processes",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_MaterialId",
                table: "Processes",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_PersonId",
                table: "Processes",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_ProcessNameId",
                table: "Processes",
                column: "ProcessNameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessDetails");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "ProcessNames");

            migrationBuilder.DropTable(
                name: "ProductCats");
        }
    }
}
