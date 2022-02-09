using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CampaignRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PersonalNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    MentorStaffId = table.Column<int>(type: "int", nullable: true),
                    MentorEndTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staffs_Staffs_MentorStaffId",
                        column: x => x.MentorStaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => new { x.EmailId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_Emails_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ArticleNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    Inventory = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampaignsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ArticleNumber);
                    table.ForeignKey(
                        name: "FK_Products_Campaigns_CampaignsID",
                        column: x => x.CampaignsID,
                        principalTable: "Campaigns",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Products_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContentLists",
                columns: table => new
                {
                    ContentId = table.Column<int>(type: "int", nullable: false),
                    ArticleNumber = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentLists", x => new { x.ContentId, x.ArticleNumber });
                    table.ForeignKey(
                        name: "FK_ContentLists_Products_ArticleNumber",
                        column: x => x.ArticleNumber,
                        principalTable: "Products",
                        principalColumn: "ArticleNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsProducts",
                columns: table => new
                {
                    DepartmentsDepartmentId = table.Column<int>(type: "int", nullable: false),
                    productsArticleNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsProducts", x => new { x.DepartmentsDepartmentId, x.productsArticleNumber });
                    table.ForeignKey(
                        name: "FK_DepartmentsProducts_Departments_DepartmentsDepartmentId",
                        column: x => x.DepartmentsDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentsProducts_Products_productsArticleNumber",
                        column: x => x.productsArticleNumber,
                        principalTable: "Products",
                        principalColumn: "ArticleNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "ID", "CampaignName", "CampaignRate" },
                values: new object[,]
                {
                    { 1, "Alv-Veckan", 0.29999999999999999 },
                    { 2, "Rea-Turn Of The King", 0.59999999999999998 },
                    { 3, "Princess Birthday", 0.14999999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "FirstName", "LastName", "MentorEndTime", "MentorStaffId", "PersonalNumber", "PhoneNumber" },
                values: new object[,]
                {
                    { 4, "Doom", "Guy", null, null, "19890111250", "070420404" },
                    { 5, "Mario", "Mario", null, null, "198303111750", "070920404" },
                    { 6, "Fox", "Mcload", null, null, "198903111250", "070420484" },
                    { 7, "Khazad", "dûm", null, null, "191201023033", "+12 10111567" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Name", "StaffId" },
                values: new object[,]
                {
                    { 5, "Bröd", 4 },
                    { 6, "Köttdisken", 4 }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "StaffId", "Email" },
                values: new object[,]
                {
                    { 4, 4, "hidden@mail.com" },
                    { 5, 5, "mario@mario.com" },
                    { 6, 5, "Mario@Nintendo.co.jp" },
                    { 7, 6, "harmony@ancient.se" },
                    { 8, 7, "'Luigi@Nintendo.co.jp" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleNumber", "CampaignsID", "ExpDate", "Inventory", "Name", "Price", "StaffId", "stock" },
                values: new object[,]
                {
                    { 4, 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mushrooms From The Shire", 89, 5, 89 },
                    { 5, 1, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4913), "Beorn’s Honey Cake", 120, 6, 20 },
                    { 7, 3, new DateTime(2050, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ent-Draught", 44, 6, 88 },
                    { 8, null, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4923), "Green Shell", 7, 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "FirstName", "LastName", "MentorEndTime", "MentorStaffId", "PersonalNumber", "PhoneNumber" },
                values: new object[,]
                {
                    { 2, "Brandybuck", "Merry", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "199903111250", "070420404" },
                    { 3, "Took", "Peregrin", new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "199001025050", "030123123" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Name", "StaffId" },
                values: new object[,]
                {
                    { 1, "Mejeri", 3 },
                    { 3, "Dryck", 3 },
                    { 4, "Skafferi", 2 }
                });

            migrationBuilder.InsertData(
                table: "DepartmentsProducts",
                columns: new[] { "DepartmentsDepartmentId", "productsArticleNumber" },
                values: new object[,]
                {
                    { 5, 7 },
                    { 6, 5 }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "StaffId", "Email" },
                values: new object[,]
                {
                    { 2, 2, "blace4life@hotmales.com" },
                    { 3, 3, "took@shire.nu" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleNumber", "CampaignsID", "ExpDate", "Inventory", "Name", "Price", "StaffId", "stock" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4873), "Fire Flower", 200, 3, 17 },
                    { 3, null, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4906), "Lembas Bread", 13, 2, 2 },
                    { 9, null, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4926), "Bannana", 15, 2, 67 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "FirstName", "LastName", "MentorEndTime", "MentorStaffId", "PersonalNumber", "PhoneNumber" },
                values: new object[] { 1, "the Bowman", "Bard", new DateTime(2034, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "199101025050", "030123123" });

            migrationBuilder.InsertData(
                table: "ContentLists",
                columns: new[] { "ArticleNumber", "ContentId", "Content" },
                values: new object[,]
                {
                    { 1, 1, "Flower" },
                    { 1, 2, "Fire" },
                    { 3, 4, "Flour" },
                    { 3, 5, "Elven Magic" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Name", "StaffId" },
                values: new object[] { 2, "Frukt", 1 });

            migrationBuilder.InsertData(
                table: "DepartmentsProducts",
                columns: new[] { "DepartmentsDepartmentId", "productsArticleNumber" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 9 },
                    { 3, 1 },
                    { 3, 7 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 8 },
                    { 5, 9 },
                    { 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "StaffId", "Email" },
                values: new object[,]
                {
                    { 1, 1, "deathToDragons@water.com" },
                    { 9, 1, "Garbage@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleNumber", "CampaignsID", "ExpDate", "Inventory", "Name", "Price", "StaffId", "stock" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4902), "Salted Pork", 67, 1, 3 },
                    { 6, 2, new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4916), "Red Shell", 67, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "ContentLists",
                columns: new[] { "ArticleNumber", "ContentId", "Content" },
                values: new object[] { 2, 3, "Pork" });

            migrationBuilder.InsertData(
                table: "DepartmentsProducts",
                columns: new[] { "DepartmentsDepartmentId", "productsArticleNumber" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 6 },
                    { 5, 6 },
                    { 6, 2 },
                    { 6, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContentLists_ArticleNumber",
                table: "ContentLists",
                column: "ArticleNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_StaffId",
                table: "Departments",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsProducts_productsArticleNumber",
                table: "DepartmentsProducts",
                column: "productsArticleNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_StaffId",
                table: "Emails",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CampaignsID",
                table: "Products",
                column: "CampaignsID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StaffId",
                table: "Products",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_MentorStaffId",
                table: "Staffs",
                column: "MentorStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_PersonalNumber",
                table: "Staffs",
                column: "PersonalNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentLists");

            migrationBuilder.DropTable(
                name: "DepartmentsProducts");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
