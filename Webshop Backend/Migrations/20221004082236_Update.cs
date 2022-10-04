using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webshop_Backend.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ItemDTOOrderDTO",
                columns: table => new
                {
                    ItemsItemID = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDTOOrderDTO", x => new { x.ItemsItemID, x.OrdersOrderID });
                    table.ForeignKey(
                        name: "FK_ItemDTOOrderDTO_Items_ItemsItemID",
                        column: x => x.ItemsItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemDTOOrderDTO_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemDTOOrderDTO_OrdersOrderID",
                table: "ItemDTOOrderDTO",
                column: "OrdersOrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDTOOrderDTO");

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
    }
}
