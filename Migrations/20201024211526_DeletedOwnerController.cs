using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class DeletedOwnerController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0856c006-11a0-474e-aef4-845890f07765");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "254c321d-befc-49c6-8ead-3c3d327534a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fd3f436-6b8b-49e6-8935-055c43999e10");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d2dd799-3c3e-423c-b5e5-1fde36f6c073", "1c4708da-a947-48b7-969c-96d05ae9bbba", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "810343a3-d164-4216-b662-ee41ea9a39b5", "93ee253c-aa50-438c-bc24-3acf7380ef6a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbee53d5-f3e8-404a-9574-ac58c8a37ca6", "390df36d-77be-4f92-9d24-5e1fd4b7ddf9", "Owner", "OWNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d2dd799-3c3e-423c-b5e5-1fde36f6c073");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "810343a3-d164-4216-b662-ee41ea9a39b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbee53d5-f3e8-404a-9574-ac58c8a37ca6");

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductSalesHistoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerId);
                    table.ForeignKey(
                        name: "FK_Owner_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owner_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Owner_ProductSalesHistories_ProductSalesHistoryId",
                        column: x => x.ProductSalesHistoryId,
                        principalTable: "ProductSalesHistories",
                        principalColumn: "ProductSalesHistoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "254c321d-befc-49c6-8ead-3c3d327534a7", "84b4952a-95ed-4bc7-a6a4-7eb78d6b600b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6fd3f436-6b8b-49e6-8935-055c43999e10", "76dd8167-ae52-4c90-979b-d5368980f816", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0856c006-11a0-474e-aef4-845890f07765", "83765cbe-3b7b-492e-bf9c-3326aa3866c6", "Owner", "OWNER" });

            migrationBuilder.CreateIndex(
                name: "IX_Owner_CustomerId",
                table: "Owner",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_IdentityUserId",
                table: "Owner",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_ProductSalesHistoryId",
                table: "Owner",
                column: "ProductSalesHistoryId");
        }
    }
}
