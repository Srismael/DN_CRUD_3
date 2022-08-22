using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.DataAccess.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "useridId",
                table: "sales",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_sales_useridId",
                table: "sales",
                newName: "IX_sales_userId");

            migrationBuilder.RenameColumn(
                name: "CategoryidId",
                table: "products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "BrandidId",
                table: "products",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryidId",
                table: "products",
                newName: "IX_products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_products_BrandidId",
                table: "products",
                newName: "IX_products_BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_BrandId",
                table: "products",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_Users_userId",
                table: "sales",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_BrandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_Users_userId",
                table: "sales");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "sales",
                newName: "useridId");

            migrationBuilder.RenameIndex(
                name: "IX_sales_userId",
                table: "sales",
                newName: "IX_sales_useridId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "products",
                newName: "CategoryidId");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "products",
                newName: "BrandidId");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryId",
                table: "products",
                newName: "IX_products_CategoryidId");

            migrationBuilder.RenameIndex(
                name: "IX_products_BrandId",
                table: "products",
                newName: "IX_products_BrandidId");

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
    }
}
