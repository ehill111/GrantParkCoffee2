using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class changedOwnermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Owner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Owner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductSalesHistoryId",
                table: "Owner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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
                name: "IX_Owner_CustomerId",
                table: "Owner",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OrderId",
                table: "Owner",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Customers_CustomerId",
                table: "Owner",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Orders_OrderId",
                table: "Owner",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Customers_CustomerId",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Orders_OrderId",
                table: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Owner_CustomerId",
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
                name: "CustomerId",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "ProductSalesHistoryId",
                table: "Owner");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

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
    }
}
