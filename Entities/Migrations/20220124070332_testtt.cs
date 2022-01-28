using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class testtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_BasketId",
                table: "products",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_baskets_BasketId",
                table: "products",
                column: "BasketId",
                principalTable: "baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_baskets_BasketId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_BasketId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "products");
        }
    }
}
