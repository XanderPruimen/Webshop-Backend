using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webshop_Backend.Migrations
{
    public partial class Marco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderDTOOrderID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemDTOItemID",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDTOOrderID",
                table: "Orders",
                column: "OrderDTOOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemDTOItemID",
                table: "Items",
                column: "ItemDTOItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ItemDTOItemID",
                table: "Items",
                column: "ItemDTOItemID",
                principalTable: "Items",
                principalColumn: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Orders_OrderDTOOrderID",
                table: "Orders",
                column: "OrderDTOOrderID",
                principalTable: "Orders",
                principalColumn: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ItemDTOItemID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Orders_OrderDTOOrderID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderDTOOrderID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemDTOItemID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OrderDTOOrderID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemDTOItemID",
                table: "Items");
        }
    }
}
