using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class onupdatenoaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252ddddb-5d27-4812-a91a-47c7e0abd57d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5504934a-a051-4809-bd82-7ddeb07abb27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5461e4e-a8df-4c60-acd7-8e5c44357148");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5f125e2-95bd-46c4-a399-7225467baeec", "611d52e7-c4c6-45f9-9bc1-a09e1382342a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f3ceb44-3b9c-43a5-b1a8-80066297fe06", "c4235811-a5bf-4ee0-b199-494b9e55d4ef", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28474e9f-3d19-450b-a34c-d6ffa3059797", "4f57d30c-7a6b-4587-945b-b098da68f049", "Owner", "OWNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28474e9f-3d19-450b-a34c-d6ffa3059797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f3ceb44-3b9c-43a5-b1a8-80066297fe06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5f125e2-95bd-46c4-a399-7225467baeec");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "252ddddb-5d27-4812-a91a-47c7e0abd57d", "8796d9fb-a163-4e42-bda5-399b5830f7fa", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5504934a-a051-4809-bd82-7ddeb07abb27", "62e8b75b-d25f-4392-aab9-c568ba08feb9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5461e4e-a8df-4c60-acd7-8e5c44357148", "7abd0d92-31dd-4d57-adb9-a80f45c7d04f", "Owner", "OWNER" });
        }
    }
}
