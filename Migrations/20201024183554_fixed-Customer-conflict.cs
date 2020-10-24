using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class fixedCustomerconflict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Owner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84f4324f-c926-45f4-8593-3162e1c4a0dd", "f0a79828-9296-4ad2-bcdd-35c49e22aafb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79654999-831b-4815-a5b2-753c923e2d91", "5f3d9aa3-bedc-4a05-ba97-85a42f47c505", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff753359-3ab5-4049-ba49-55a91c6b4c20", "f600d97c-0844-4d37-bdf1-0b97daf1e1b3", "Owner", "OWNER" });

            migrationBuilder.CreateIndex(
                name: "IX_Owner_CustomerId",
                table: "Owner",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Customers_CustomerId",
                table: "Owner",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Customers_CustomerId",
                table: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Owner_CustomerId",
                table: "Owner");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79654999-831b-4815-a5b2-753c923e2d91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84f4324f-c926-45f4-8593-3162e1c4a0dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff753359-3ab5-4049-ba49-55a91c6b4c20");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Owner");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Owner",
                type: "int",
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
    }
}
