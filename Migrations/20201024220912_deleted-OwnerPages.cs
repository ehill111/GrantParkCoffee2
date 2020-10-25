using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class deletedOwnerPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "299684df-5075-4cba-9fc5-0bfb045d0cee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fd2646-682d-4d8d-8d83-c8cf39c05d74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523e1cea-02be-446f-80a3-918f969760fe");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "299684df-5075-4cba-9fc5-0bfb045d0cee", "b8047d07-d932-4dc5-942f-6ae136d764e5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "523e1cea-02be-446f-80a3-918f969760fe", "e379b6b3-b21d-46b9-a5a7-e751359b1260", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42fd2646-682d-4d8d-8d83-c8cf39c05d74", "59c2cbee-ddf1-442a-ac52-7bc784983db0", "Owner", "OWNER" });
        }
    }
}
