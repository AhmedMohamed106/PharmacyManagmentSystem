using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SaleItemAndPurchaseItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_products_Product_ID",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_products_Product_ID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_Product_ID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_Product_ID",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Product_ID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Product_Quantity",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Product_ID",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Product_Quantity",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Patch_Num",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Purchase_Rate",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Sale_Rate",
                table: "products",
                newName: "Category_ID");

            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "purchaseItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purchase_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Purchase_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchaseItems_Purchases_Purchase_ID",
                        column: x => x.Purchase_ID,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchaseItems_products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saleItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sale_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Sale_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_saleItems_Sales_Sale_ID",
                        column: x => x.Sale_ID,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saleItems_products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_Category_ID",
                table: "products",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseItems_Product_ID",
                table: "purchaseItems",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseItems_Purchase_ID",
                table: "purchaseItems",
                column: "Purchase_ID");

            migrationBuilder.CreateIndex(
                name: "IX_saleItems_Product_ID",
                table: "saleItems",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_saleItems_Sale_ID",
                table: "saleItems",
                column: "Sale_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_Category_ID",
                table: "products",
                column: "Category_ID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_Category_ID",
                table: "products");

            migrationBuilder.DropTable(
                name: "purchaseItems");

            migrationBuilder.DropTable(
                name: "saleItems");

            migrationBuilder.DropIndex(
                name: "IX_products_Category_ID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Category_ID",
                table: "products",
                newName: "Sale_Rate");

            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Product_ID",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Product_Quantity",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Product_ID",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Product_Quantity",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Patch_Num",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Purchase_Rate",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Product_ID",
                table: "Sales",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_Product_ID",
                table: "Purchases",
                column: "Product_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_products_Product_ID",
                table: "Purchases",
                column: "Product_ID",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_products_Product_ID",
                table: "Sales",
                column: "Product_ID",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
