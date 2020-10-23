using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class addingroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6747ad86-73f3-4f57-a0aa-a03311cbef82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4a06791-8dd7-40da-a881-63f6a0301e22", "6bc5e7b8-2fe8-4823-a0ca-e649ebf6ec36", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "322697fe-21e7-4df3-adba-45d1a97e166f", "4a03815a-bf8e-44aa-be0d-a83c385e34ca", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1cb3380-6c22-4e62-91ca-817b06ea83d7", "e30d6b30-3c32-4c0f-a936-0ecdfb2ca90a", "Owner", "OWNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "322697fe-21e7-4df3-adba-45d1a97e166f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4a06791-8dd7-40da-a881-63f6a0301e22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1cb3380-6c22-4e62-91ca-817b06ea83d7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6747ad86-73f3-4f57-a0aa-a03311cbef82", "68c032e4-5369-44ee-8ab7-873086328678", "Admin", "ADMIN" });
        }
    }
}
