using System.Collections.Generic;
using FiveRingsDb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveRingsDb.Migrations
{
    public partial class AddTraitsListConversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<List<string>>(
                name: "Traits",
                table: "Cards",
                nullable: true,
                oldClrType: typeof(List<Trait>),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<List<Trait>>(
                name: "Traits",
                table: "Cards",
                nullable: true,
                oldClrType: typeof(List<string>),
                oldNullable: true);
        }
    }
}
