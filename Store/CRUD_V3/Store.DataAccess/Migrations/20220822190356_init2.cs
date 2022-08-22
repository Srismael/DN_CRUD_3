using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_BrandIdId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryIdId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_Users_userIDId",
                table: "sales");

            migrationBuilder.RenameColumn(
                name: "userIDId",
                table: "sales",
                newName: "useridId");

            migrationBuilder.RenameIndex(
                name: "IX_sales_userIDId",
                table: "sales",
                newName: "IX_sales_useridId");

            migrationBuilder.RenameColumn(
                name: "CategoryIdId",
                table: "products",
                newName: "CategoryidId");

            migrationBuilder.RenameColumn(
                name: "BrandIdId",
                table: "products",
                newName: "BrandidId");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryIdId",
                table: "products",
                newName: "IX_products_CategoryidId");

            migrationBuilder.RenameIndex(
                name: "IX_products_BrandIdId",
                table: "products",
                newName: "IX_products_BrandidId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_BrandidId",
                table: "products",
                column: "BrandidId",
                principalTable: "brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryidId",
                table: "products",
                column: "CategoryidId",
                principalTable: "categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_Users_useridId",
                table: "sales",
                column: "useridId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_BrandidId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryidId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_Users_useridId",
                table: "sales");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "useridId",
                table: "sales",
                newName: "userIDId");

            migrationBuilder.RenameIndex(
                name: "IX_sales_useridId",
                table: "sales",
                newName: "IX_sales_userIDId");

            migrationBuilder.RenameColumn(
                name: "CategoryidId",
                table: "products",
                newName: "CategoryIdId");

            migrationBuilder.RenameColumn(
                name: "BrandidId",
                table: "products",
                newName: "BrandIdId");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryidId",
                table: "products",
                newName: "IX_products_CategoryIdId");

            migrationBuilder.RenameIndex(
                name: "IX_products_BrandidId",
                table: "products",
                newName: "IX_products_BrandIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_BrandIdId",
                table: "products",
                column: "BrandIdId",
                principalTable: "brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryIdId",
                table: "products",
                column: "CategoryIdId",
                principalTable: "categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_Users_userIDId",
                table: "sales",
                column: "userIDId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
