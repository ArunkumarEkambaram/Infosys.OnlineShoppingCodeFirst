using Microsoft.EntityFrameworkCore.Migrations;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Migrations
{
    public partial class CreateUSPMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Create Procedure usp_AddNewMovie(@MovieName varchar(50), @Language varchar(50), @Budget decimal, @GenreId int)"+
                                    "as " +
                                "Insert Movies(MovieName, Language, Budget, GenreId) values(@MovieName, @Language, @Budget, @GenreId)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
