using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class reconciledCustomerNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b7bc507-ed2b-4587-b5ec-67a3269c20f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a48dd3ef-af53-4010-93ab-c6b775e3df95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d312e617-f108-4dde-be50-73ee8a363ad5");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Owner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6138fd3-ddd1-46c2-a2f8-dc5699dceb73", "c9896841-1c65-49c8-bd56-d01dacbbda0e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e655791-de7d-4191-acfa-a62ef264a89c", "2e3a4b40-f209-4250-abd9-2889af99c397", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d32bdb9-ff25-4b62-a6ad-bf21f178711c", "8178f923-3105-4bef-a290-a7acd6215ac8", "Owner", "OWNER" });

            migrationBuilder.CreateIndex(
                name: "IX_Owner_Id",
                table: "Owner",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Customers_Id",
                table: "Owner",
                column: "Id",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Customers_Id",
                table: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Owner_Id",
                table: "Owner");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e655791-de7d-4191-acfa-a62ef264a89c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d32bdb9-ff25-4b62-a6ad-bf21f178711c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6138fd3-ddd1-46c2-a2f8-dc5699dceb73");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Owner");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b7bc507-ed2b-4587-b5ec-67a3269c20f7", "08ad73ae-ba3e-4eba-85f1-a5983e482be0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d312e617-f108-4dde-be50-73ee8a363ad5", "7437755c-3f64-41c1-a18f-ec1ed9c8bfb0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a48dd3ef-af53-4010-93ab-c6b775e3df95", "08f09fa3-6d90-4bb0-9536-61016236f875", "Owner", "OWNER" });
        }
    }
}
