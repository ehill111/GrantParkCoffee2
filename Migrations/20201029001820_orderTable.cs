using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Migrations
{
    public partial class orderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bba5750-adf1-4d9d-b459-b35e54a6a5a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9811a515-43c3-48bb-b936-422d4b7b6bfb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a844b12-f741-4bdd-9f76-b90442cfcb2c");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderPlaced",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aee1614d-81b2-4cf9-a01e-cd4b6d681728", "f954c1aa-1d38-44ec-bcc3-06209b34a920", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89a6e267-a478-46ee-bd5e-146270b4c777", "78336c4c-8940-4d12-b0a8-93291bd18845", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9511325-82db-448e-9d05-2dbac8d07568", "3972f2a1-36aa-4c0a-be40-d9282e525bd9", "Owner", "OWNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89a6e267-a478-46ee-bd5e-146270b4c777");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aee1614d-81b2-4cf9-a01e-cd4b6d681728");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9511325-82db-448e-9d05-2dbac8d07568");

            migrationBuilder.DropColumn(
                name: "OrderPlaced",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a844b12-f741-4bdd-9f76-b90442cfcb2c", "d6637764-357a-4645-8563-e63c6f2dffa0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9811a515-43c3-48bb-b936-422d4b7b6bfb", "f8eb3112-a2d2-4389-a858-1dcf135e971a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3bba5750-adf1-4d9d-b459-b35e54a6a5a7", "21f44437-11c1-4687-b6b0-75f9190ad4b9", "Owner", "OWNER" });
        }
    }
}
