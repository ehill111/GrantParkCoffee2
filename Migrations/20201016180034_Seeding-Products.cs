using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class SeedingProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c29fefac-5b1f-4d20-a12b-4eac6110b98d");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductType = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: false),
                    ProductFeatured = table.Column<bool>(nullable: false),
                    ProductOnDiscountSale = table.Column<bool>(nullable: false),
                    RewardEligible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "825a4781-1f5a-4e38-9bf0-a74699779b11", "819ac68a-0bc5-4685-bb70-fde57de01b60", "Admin", "ADMIN" });

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
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "825a4781-1f5a-4e38-9bf0-a74699779b11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c29fefac-5b1f-4d20-a12b-4eac6110b98d", "f7fca390-683d-44f6-9e9e-43c71e75625e", "Admin", "ADMIN" });
        }
    }
}
