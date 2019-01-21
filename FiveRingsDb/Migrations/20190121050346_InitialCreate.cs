using System.Collections.Generic;
using FiveRingsDb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveRingsDb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NameCanonical = table.Column<string>(nullable: true),
                    Traits = table.Column<List<Trait>>(nullable: true),
                    Side = table.Column<int>(nullable: false),
                    DeckLimit = table.Column<int>(nullable: false),
                    Clan = table.Column<int>(nullable: false),
                    IsUnique = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    IsRestricted = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    TextCanonical = table.Column<string>(nullable: true),
                    RoleRestriction = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Cost = table.Column<int>(nullable: true),
                    MilitaryBonus = table.Column<string>(nullable: true),
                    PoliticalBonus = table.Column<string>(nullable: true),
                    InfluenceCost = table.Column<int>(nullable: true),
                    CharacterCard_Cost = table.Column<int>(nullable: true),
                    Military = table.Column<string>(nullable: true),
                    Political = table.Column<string>(nullable: true),
                    Glory = table.Column<int>(nullable: true),
                    CharacterCard_InfluenceCost = table.Column<int>(nullable: true),
                    EventCard_Cost = table.Column<int>(nullable: true),
                    EventCard_InfluenceCost = table.Column<int>(nullable: true),
                    StrengthBonus = table.Column<string>(nullable: true),
                    Element = table.Column<int>(nullable: true),
                    Strength = table.Column<string>(nullable: true),
                    InfluencePool = table.Column<int>(nullable: true),
                    Fate = table.Column<int>(nullable: true),
                    StrongholdCard_StrengthBonus = table.Column<string>(nullable: true),
                    Honor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrintedCards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Illustrator = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Pack = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    CardId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintedCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrintedCards_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrintedCards_CardId",
                table: "PrintedCards",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrintedCards");

            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
