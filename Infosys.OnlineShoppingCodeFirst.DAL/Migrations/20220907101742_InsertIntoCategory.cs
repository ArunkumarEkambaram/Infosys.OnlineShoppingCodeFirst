using Microsoft.EntityFrameworkCore.Migrations;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Migrations
{
    public partial class InsertIntoCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Categories(CategoryName) values ('Electronics')");
            migrationBuilder.Sql("Insert Categories(CategoryName) values ('Appliances')");
            migrationBuilder.Sql("Insert Categories(CategoryName) values ('Mobiles')");
            migrationBuilder.Sql("Insert Categories(CategoryName) values ('Toys')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
