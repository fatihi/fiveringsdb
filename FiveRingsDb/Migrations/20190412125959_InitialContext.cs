using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FiveRingsDb.Migrations
{
    public partial class InitialContext : Migration
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
                    Side = table.Column<string>(nullable: false),
                    DeckLimit = table.Column<int>(nullable: false),
                    Clan = table.Column<string>(nullable: false),
                    IsUnique = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    IsRestricted = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    TextCanonical = table.Column<string>(nullable: true),
                    RoleRestriction = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AttachmentCost = table.Column<int>(nullable: true),
                    MilitaryBonus = table.Column<string>(nullable: true),
                    PoliticalBonus = table.Column<string>(nullable: true),
                    AttachmentInfluenceCost = table.Column<int>(nullable: true),
                    CharacterCost = table.Column<int>(nullable: true),
                    Military = table.Column<string>(nullable: true),
                    Political = table.Column<string>(nullable: true),
                    Glory = table.Column<int>(nullable: true),
                    CharacterInfluenceCost = table.Column<int>(nullable: true),
                    EventCost = table.Column<int>(nullable: true),
                    EventInfluenceCost = table.Column<int>(nullable: true),
                    HoldingStrengthBonus = table.Column<string>(nullable: true),
                    Element = table.Column<string>(nullable: true),
                    Strength = table.Column<string>(nullable: true),
                    InfluencePool = table.Column<int>(nullable: true),
                    Fate = table.Column<int>(nullable: true),
                    StrongholdStrengthBonus = table.Column<string>(nullable: true),
                    Honor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TraitEnum = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    CardId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keywords_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrintedCards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Illustrator = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Pack = table.Column<string>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "TraitOnCard",
                columns: table => new
                {
                    TraitId = table.Column<int>(nullable: false),
                    CardId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraitOnCard", x => new { x.CardId, x.TraitId });
                    table.ForeignKey(
                        name: "FK_TraitOnCard_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraitOnCard_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraitInKeywordException",
                columns: table => new
                {
                    TraitId = table.Column<int>(nullable: false),
                    KeywordId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraitInKeywordException", x => new { x.KeywordId, x.TraitId });
                    table.ForeignKey(
                        name: "FK_TraitInKeywordException_Keywords_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraitInKeywordException_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraitInKeywordRestriction",
                columns: table => new
                {
                    TraitId = table.Column<int>(nullable: false),
                    KeywordId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraitInKeywordRestriction", x => new { x.KeywordId, x.TraitId });
                    table.ForeignKey(
                        name: "FK_TraitInKeywordRestriction_Keywords_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraitInKeywordRestriction_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_Id",
                table: "Cards",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_CardId",
                table: "Keywords",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_Id",
                table: "Keywords",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PrintedCards_CardId",
                table: "PrintedCards",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_PrintedCards_Id",
                table: "PrintedCards",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TraitInKeywordException_TraitId",
                table: "TraitInKeywordException",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_TraitInKeywordRestriction_TraitId",
                table: "TraitInKeywordRestriction",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_TraitOnCard_TraitId",
                table: "TraitOnCard",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_Id",
                table: "Traits",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrintedCards");

            migrationBuilder.DropTable(
                name: "TraitInKeywordException");

            migrationBuilder.DropTable(
                name: "TraitInKeywordRestriction");

            migrationBuilder.DropTable(
                name: "TraitOnCard");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
