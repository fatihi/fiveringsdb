using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveRingsDb.Migrations
{
    public partial class FixKeywordsTableNameAndRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardId",
                table: "Keyword",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Keyword_CardId",
                table: "Keyword",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keyword_Cards_CardId",
                table: "Keyword",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keyword_Cards_CardId",
                table: "Keyword");

            migrationBuilder.DropIndex(
                name: "IX_Keyword_CardId",
                table: "Keyword");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Keyword");
        }
    }
}
