using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
