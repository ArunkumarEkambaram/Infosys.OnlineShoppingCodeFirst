using Microsoft.EntityFrameworkCore.Migrations;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Migrations
{
    public partial class AlternateMobieNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlternateMobileNo",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternateMobileNo",
                table: "Customers");
        }
    }
}
