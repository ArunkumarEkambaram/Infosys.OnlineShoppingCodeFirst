using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Migrations
{
    public partial class CreateTableOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    OrderedQuantity = table.Column<int>(nullable: false),
                    ActualDeliveryDate = table.Column<DateTime>(nullable: true),
                    EstimatedDeliveryDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()+5")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
