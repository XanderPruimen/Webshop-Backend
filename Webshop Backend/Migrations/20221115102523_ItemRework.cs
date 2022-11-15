using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webshop_Backend.Migrations
{
    public partial class ItemRework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(500)", nullable: false),
                    ItemInfo = table.Column<string>(type: "varchar(500)", nullable: false),
                    ItemImage = table.Column<string>(type: "varchar(500)", nullable: false),
                    ItemPrice = table.Column<string>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
