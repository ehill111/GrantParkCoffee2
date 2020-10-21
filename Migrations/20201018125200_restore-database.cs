using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class restoredatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87406132-b326-4b3e-b357-087bde2e6115", "20e8b984-dded-45ec-9979-674fb68e312c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductFeatured", "ProductName", "ProductOnDiscountSale", "ProductPrice", "ProductType", "RewardEligible" },
                values: new object[,]
                {
                    { 1, false, "Bacon, Egg, and Cheese Croissant", false, 6.9900000000000002, "Food", true },
                    { 2, true, "Chicken Salad Sandwich", false, 6.9900000000000002, "Food", true },
                    { 3, false, "Creamy Cheese Grits", false, 2.9900000000000002, "Food", true },
                    { 4, false, "Spinach Salad", false, 6.9900000000000002, "Food", true },
                    { 5, false, "Banana Nut Bread", false, 2.9900000000000002, "Dessert", true },
                    { 6, false, "Chocolate Chip Skone", false, 2.9900000000000002, "Dessert", true },
                    { 7, false, "Blueberry Muffin", false, 2.9900000000000002, "Dessert", true },
                    { 8, false, "Coffee", false, 2.4900000000000002, "Beverage", true },
                    { 9, false, "Juice", false, 2.9900000000000002, "Beverage", true },
                    { 10, false, "Water", false, 1.49, "Beverage", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87406132-b326-4b3e-b357-087bde2e6115");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10);
        }
    }
}
