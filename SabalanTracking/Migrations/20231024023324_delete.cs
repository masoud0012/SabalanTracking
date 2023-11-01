using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SabalanTracking.Migrations
{
    /// <inheritdoc />
    public partial class delete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SN = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    { new Guid("003fc3e0-8a0c-40aa-8a4d-b037267ebaea"), " ", "دستگاه تزریق شماره 1" },
                    { new Guid("2761a3a4-9e8b-4b10-8812-69314cce08ee"), " ", "دستگاه تزریق شماره 4" },
                    { new Guid("35ede537-b968-44d4-bb00-6f817e6d0c5c"), " ", "دستگاه برش التراسونیک پارچه" },
                    { new Guid("6668d620-7fce-4783-901d-0d59994bcd2d"), " ", "دستگاه جوش التراسونیک" },
                    { new Guid("75267e76-9f8b-4a21-ad3f-a05a34ff2772"), " ", "دستگاه سیلر بسته بندی" },
                    { new Guid("7954f335-9e55-4cdc-b3d3-2097bc6dafb3"), " ", "دستگاه تزریق شماره 2" },
                    { new Guid("9fc05371-9b98-4b8e-9302-1518290148b6"), " ", "دستگاه تزریق شماره 3" },
                    { new Guid("da5d78d5-02ec-4186-a708-fdaa8b591d27"), " ", "دستگاه تزریق شماره عباسی" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("42c5e395-a784-4975-86b8-af29ae4220ed"), "پژمان" },
                    { new Guid("55bb7053-f2b4-405c-9b5c-8ecb4ede0f22"), "رضا" },
                    { new Guid("7b2081cb-ccc6-4d81-95b3-c01c5b4d359e"), "مهندس عبدالله پور" },
                    { new Guid("7b50fea1-cce1-43f4-a5f3-f141f1367505"), "عباسی" },
                    { new Guid("be7d08c4-d227-4a6e-8a9d-234ad6bc62a9"), "مسعود" },
                    { new Guid("becbfd78-bc37-419d-a12b-1e4f3f3a46bb"), "اپراتور 1 عباسی" },
                    { new Guid("f0e199f6-7d67-4111-89cf-bcd57029bfc4"), "اپراتور 2 عبداللهی" }
                });

            migrationBuilder.InsertData(
                table: "ProcessNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("22e4e3ef-523b-4582-9531-09da5daa2cf5"), "جوش التراسونیک" },
                    { new Guid("8233d591-21c3-4b86-9725-ae84ad56a191"), "برش پارچه" },
                    { new Guid("aed762ea-c4ca-4dcb-9429-f50096ae589f"), "تزریق پلاستیک" },
                    { new Guid("deed5511-831f-4943-bb34-554844d81430"), "بسته بندی" },
                    { new Guid("e592ac73-dfe9-4c32-9404-60526a0e8f5d"), "خرید" }
                });

            migrationBuilder.InsertData(
                table: "ProductCats",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { new Guid("5efae653-911d-40c9-aaa5-666135fe4a85"), "FinalProduct" },
                    { new Guid("868ecb86-545f-413c-91b4-e15a73f99ddc"), "RawMaterial" },
                    { new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "Semi Final Prodct" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "CatId", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("2022077b-a281-4f92-a9b1-6e484dd10673"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "بدنه فیلتر آنتی باکتریال با درپوش", "عدد" },
                    { new Guid("437ee4fe-2fe4-4f8c-ae5d-2d41e7fd80a0"), new Guid("868ecb86-545f-413c-91b4-e15a73f99ddc"), "پلی پروپیلن-PP", "کیلوگرم" },
                    { new Guid("44f3b369-cc54-418f-a16a-ea936cbb4ac8"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "فیلتر ویپک HME", "عدد" },
                    { new Guid("47c6036e-4a5a-4687-a6f5-d1b1737ed94f"), new Guid("5efae653-911d-40c9-aaa5-666135fe4a85"), "فیلتر HME", "عدد" },
                    { new Guid("501ad51a-742b-4728-ad77-c122f1c25471"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "بدنه فیلتر اسپیرومتری شماره 1", "عدد" },
                    { new Guid("56d4f7fe-acad-44f5-8313-0b536505537c"), new Guid("868ecb86-545f-413c-91b4-e15a73f99ddc"), "اسپان باند", "کیلوگرم" },
                    { new Guid("5c41e3c0-7ddc-4f63-92a4-dacab5d32bd6"), new Guid("868ecb86-545f-413c-91b4-e15a73f99ddc"), "PVC", "کیلوگرم" },
                    { new Guid("75879f56-0c43-4de8-afc3-f05026e260b9"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "ویپک VFE", "عدد" },
                    { new Guid("869784d8-b821-4e82-bef4-d8a924bfbe33"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "درپوش", "عدد" },
                    { new Guid("91369451-9d26-4fa3-a182-143dea3062c8"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "بدنه فیلتر اسپیرومتری شماره 2", "عدد" },
                    { new Guid("aff6c1d9-4834-4588-a835-14a683e502a8"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "بدنه فیلتر HME با درپوش", "عدد" },
                    { new Guid("b155638c-1d73-4cbf-ab11-738fe5ab1770"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "ویپک اسپیرومتری", "عدد" },
                    { new Guid("c1d74061-62e4-4b88-9284-c7a574126aeb"), new Guid("868ecb86-545f-413c-91b4-e15a73f99ddc"), "ملت بلون", "کیلوگرم" },
                    { new Guid("c9e6ef94-7c35-4135-b947-6e61fe50cad9"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "بدنه فیلتر آنتی باکتریال بدون درپوش", "عدد" },
                    { new Guid("d2f83526-bf87-4e47-b29f-af82d0eb4bdb"), new Guid("5efae653-911d-40c9-aaa5-666135fe4a85"), "فیلتر VFE", "عدد" },
                    { new Guid("e667e9c0-7811-4cef-b935-965fb434c9b4"), new Guid("868ecb86-545f-413c-91b4-e15a73f99ddc"), "کاغذ جاذب رطوبت", "عدد" },
                    { new Guid("f35d2712-0808-48e8-b8df-c22067a6676f"), new Guid("5efae653-911d-40c9-aaa5-666135fe4a85"), "فیلتر اسپیرومتری", "عدد" },
                    { new Guid("f3828063-762a-4c1d-ba90-c4b33b945b6b"), new Guid("868ecb86-545f-413c-91b4-e15a73f99ddc"), "پلی استایرن-PS", "کیلوگرم" },
                    { new Guid("ff06ec45-4aec-4006-b114-0739a804ba01"), new Guid("b234824c-9ddd-4ab1-8626-3f5fa259a4d1"), "بدنه فیلتر HME بدون درپوش", "عدد" }
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
    }
}
