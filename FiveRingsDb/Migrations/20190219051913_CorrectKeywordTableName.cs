using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveRingsDb.Migrations
{
    public partial class CorrectKeywordTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keyword_Cards_CardId",
                table: "Keyword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Keyword",
                table: "Keyword");

            migrationBuilder.RenameTable(
                name: "Keyword",
                newName: "Keywords");

            migrationBuilder.RenameIndex(
                name: "IX_Keyword_Id",
                table: "Keywords",
                newName: "IX_Keywords_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Keyword_CardId",
                table: "Keywords",
                newName: "IX_Keywords_CardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Keywords_Cards_CardId",
                table: "Keywords",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keywords_Cards_CardId",
                table: "Keywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords");

            migrationBuilder.RenameTable(
                name: "Keywords",
                newName: "Keyword");

            migrationBuilder.RenameIndex(
                name: "IX_Keywords_Id",
                table: "Keyword",
                newName: "IX_Keyword_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Keywords_CardId",
                table: "Keyword",
                newName: "IX_Keyword_CardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keyword",
                table: "Keyword",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Keyword_Cards_CardId",
                table: "Keyword",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
