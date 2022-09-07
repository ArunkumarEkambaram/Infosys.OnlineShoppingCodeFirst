using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Migrations
{
    public partial class AddNewColumnDateOfBirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customers",
                nullable: false
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Customers");
        }
    }
}
