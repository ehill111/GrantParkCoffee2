using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class fixingconflict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "3255e54a-b790-46bd-b333-a5a40c98263b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2e67dc2-712b-49b9-ba20-a0dc88e8a69d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3572fbd-5c78-4626-bc84-f21689d0b1ed");

            migrationBuilder.DropColumn(
                name: "CustomerId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CustomerId",
                table: "Owner",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2e67dc2-712b-49b9-ba20-a0dc88e8a69d", "1673649d-b92d-4278-9c82-d833c5649a59", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3572fbd-5c78-4626-bc84-f21689d0b1ed", "d001e325-136f-4984-8215-87d8a65afc28", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3255e54a-b790-46bd-b333-a5a40c98263b", "ccbe2ca5-0cf2-4e77-93f8-4a0d7f432b4e", "Owner", "OWNER" });

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
    }
}
