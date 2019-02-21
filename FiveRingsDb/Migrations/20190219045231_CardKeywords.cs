using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveRingsDb.Migrations
{
    public partial class CardKeywords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Keyword",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Exceptions = table.Column<List<string>>(nullable: true),
                    Restrictions = table.Column<List<string>>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Keyword_Id",
                table: "Keyword",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keyword");
        }
    }
}
