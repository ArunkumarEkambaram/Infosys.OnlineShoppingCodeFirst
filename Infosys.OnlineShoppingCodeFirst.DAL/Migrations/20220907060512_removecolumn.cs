using Microsoft.EntityFrameworkCore.Migrations;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Migrations
{
    public partial class removecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternateMobileNo",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlternateMobileNo",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
