using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class correctingtableconflict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Orders_OrderId",
                table: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Owner_OrderId",
                table: "Owner");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a3e58f0-0ca5-4547-b837-0d5e738a1e8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2a59a2c-8d41-499c-ad2d-edb54dc44d71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c96e5d61-589f-4ccd-8158-57fd9cd35f63");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Owner");

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
                name: "IX_Owner_ProductSalesHistoryId",
                table: "Owner",
                column: "ProductSalesHistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_ProductSalesHistories_ProductSalesHistoryId",
                table: "Owner",
                column: "ProductSalesHistoryId",
                principalTable: "ProductSalesHistories",
                principalColumn: "ProductSalesHistoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_ProductSalesHistories_ProductSalesHistoryId",
                table: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Owner_ProductSalesHistoryId",
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

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Owner",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2a59a2c-8d41-499c-ad2d-edb54dc44d71", "5621ab23-165c-4609-9e79-c04a8aa1bded", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a3e58f0-0ca5-4547-b837-0d5e738a1e8d", "ee88262f-7e9b-4f90-94b7-088442a42443", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c96e5d61-589f-4ccd-8158-57fd9cd35f63", "84d2b79b-9763-4d01-8abc-9a2b7bc2842a", "Owner", "OWNER" });

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OrderId",
                table: "Owner",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Orders_OrderId",
                table: "Owner",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
