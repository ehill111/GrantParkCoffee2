using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class AddedPropertyToProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12527a1e-f334-4abc-a6ce-db09b39ba7d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44085ce0-3fce-4659-9187-ab825e19411c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b381cf47-731a-415d-b67a-f39bfcafdc16");

            migrationBuilder.AddColumn<bool>(
                name: "Purchase",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bb369ba-3b63-4c0b-8af1-9e0f08a614ec", "85f1f8e9-687c-4f92-9af0-d4f30b14b093", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31df1fdd-60a6-4cc4-b2fa-0500f70f347c", "cebea452-a6df-4cc8-a6c6-c904679629da", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6243299-5183-458b-b747-7e855220df84", "cc061df3-52ed-4a39-8eb9-a531a51acfb9", "Owner", "OWNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31df1fdd-60a6-4cc4-b2fa-0500f70f347c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb369ba-3b63-4c0b-8af1-9e0f08a614ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6243299-5183-458b-b747-7e855220df84");

            migrationBuilder.DropColumn(
                name: "Purchase",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12527a1e-f334-4abc-a6ce-db09b39ba7d6", "887a2159-19b8-4088-a84c-7b952c385413", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44085ce0-3fce-4659-9187-ab825e19411c", "792219d8-35a9-4e7a-8954-a6ae00c2b0e7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b381cf47-731a-415d-b67a-f39bfcafdc16", "4399e76c-e982-4ae0-80e9-e88919bad5cf", "Owner", "OWNER" });
        }
    }
}
