using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class resumecore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSalesHistory_Order_OrderId",
                table: "ProductSalesHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSalesHistory_Product_ProductId",
                table: "ProductSalesHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomReservation_Customer_CustomerId",
                table: "RoomReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Order_OrderId",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Product_ProductId",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomReservation",
                table: "RoomReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSalesHistory",
                table: "ProductSalesHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87406132-b326-4b3e-b357-087bde2e6115");

            migrationBuilder.DropColumn(
                name: "ProductOnDiscountSale",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                newName: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "RoomReservation",
                newName: "RoomReservations");

            migrationBuilder.RenameTable(
                name: "ProductSalesHistory",
                newName: "ProductSalesHistories");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCart_ProductId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCart_OrderId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomReservation_CustomerId",
                table: "RoomReservations",
                newName: "IX_RoomReservations_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSalesHistory_ProductId",
                table: "ProductSalesHistories",
                newName: "IX_ProductSalesHistories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSalesHistory_OrderId",
                table: "ProductSalesHistories",
                newName: "IX_ProductSalesHistories_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customers",
                newName: "IX_Customers_IdentityUserId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ProductOnSale",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "ShoppingCartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomReservations",
                table: "RoomReservations",
                column: "RoomReservationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSalesHistories",
                table: "ProductSalesHistories",
                column: "ProductSalesHistoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f3f2b97-dc0d-4ffe-827b-93f954222df6", "779008cf-3db9-45cf-ab5a-7042dadf7dc1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Food", null },
                    { 2, "Dessert", null },
                    { 3, "Beverage", null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 1, "Available with pork or turkey bacon.", "", 6.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 1, "Tasty chicken piled high on wheat, rye, or white bread, with lettuce and tomato.", "", 6.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 1, "Don't get mad at Momma and Grandmama because their grits aren't as tasty as ours. They're only human!", "", 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 1, "Spinach, apples, red onion, toasted walnut halves, dried cranberries, goat cheese, and our special dressing.", "", 6.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 2, "Would you like a little warm butter on that?", "", 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 2, "Chocolate. Chip. Skone. What else is there to say? What? Fresh? Fresh is who we are!", "", 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 2, "Oh. My. Goodness. GOOD!", "", 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 3, "Every delicious cup of coffee you purchase helps support a local shelter for victims of domestic abuse.", "", 2.4900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 3, "Cranberry. Orange. Apple. Just say the word.", "", 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CategoryID", "Description", "ImagePath", "UnitPrice" },
                values: new object[] { 3, "Twelve ounces of life. And you can have it room temperature or cool!", "", 1.49 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProductId",
                table: "Items",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSalesHistories_Orders_OrderId",
                table: "ProductSalesHistories",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSalesHistories_Products_ProductId",
                table: "ProductSalesHistories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomReservations_Customers_CustomerId",
                table: "RoomReservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Orders_OrderId",
                table: "ShoppingCarts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSalesHistories_Orders_OrderId",
                table: "ProductSalesHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSalesHistories_Products_ProductId",
                table: "ProductSalesHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomReservations_Customers_CustomerId",
                table: "RoomReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Orders_OrderId",
                table: "ShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomReservations",
                table: "RoomReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSalesHistories",
                table: "ProductSalesHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f3f2b97-dc0d-4ffe-827b-93f954222df6");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductOnSale",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "ShoppingCart");

            migrationBuilder.RenameTable(
                name: "RoomReservations",
                newName: "RoomReservation");

            migrationBuilder.RenameTable(
                name: "ProductSalesHistories",
                newName: "ProductSalesHistory");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCart",
                newName: "IX_ShoppingCart_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_OrderId",
                table: "ShoppingCart",
                newName: "IX_ShoppingCart_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomReservations_CustomerId",
                table: "RoomReservation",
                newName: "IX_RoomReservation_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSalesHistories_ProductId",
                table: "ProductSalesHistory",
                newName: "IX_ProductSalesHistory_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSalesHistories_OrderId",
                table: "ProductSalesHistory",
                newName: "IX_ProductSalesHistory_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Order",
                newName: "IX_Order_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customer",
                newName: "IX_Customer_IdentityUserId");

            migrationBuilder.AddColumn<bool>(
                name: "ProductOnDiscountSale",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "ProductPrice",
                table: "Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "ShoppingCartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomReservation",
                table: "RoomReservation",
                column: "RoomReservationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSalesHistory",
                table: "ProductSalesHistory",
                column: "ProductSalesHistoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87406132-b326-4b3e-b357-087bde2e6115", "20e8b984-dded-45ec-9979-674fb68e312c", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductPrice",
                value: 6.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductPrice",
                value: 6.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductPrice",
                value: 2.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ProductPrice",
                value: 6.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductPrice",
                value: 2.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductPrice",
                value: 2.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductPrice",
                value: 2.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "ProductPrice",
                value: 2.4900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "ProductPrice",
                value: 2.9900000000000002);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "ProductPrice",
                value: 1.49);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSalesHistory_Order_OrderId",
                table: "ProductSalesHistory",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSalesHistory_Product_ProductId",
                table: "ProductSalesHistory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomReservation_Customer_CustomerId",
                table: "RoomReservation",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Order_OrderId",
                table: "ShoppingCart",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Product_ProductId",
                table: "ShoppingCart",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
