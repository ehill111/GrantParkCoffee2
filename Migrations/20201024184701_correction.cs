using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32ef3323-85e2-41b3-af6a-e9a8bcbe902d", "8fdbb447-1658-4c46-9380-2be3a0099ab6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a042f8f6-a744-4665-97b3-a1702619c481", "2f8bbfab-c2e9-40c1-a330-a8e6b141c9ec", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f9483f5-be82-4f10-b610-ffda6b758450", "0ce7bd4b-57d3-4cf9-ae3d-dd7e4998fe57", "Owner", "OWNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32ef3323-85e2-41b3-af6a-e9a8bcbe902d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f9483f5-be82-4f10-b610-ffda6b758450");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a042f8f6-a744-4665-97b3-a1702619c481");

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
        }
    }
}
