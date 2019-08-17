using System.Collections.Generic;
using FiveRingsDb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveRingsDb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:card_type", "event,province,attachment,character,holding,stronghold,role")
                .Annotation("Npgsql:Enum:clan", "crab,crane,dragon,lion,neutral,phoenix,scorpion,unicorn")
                .Annotation("Npgsql:Enum:element", "air,earth,fire,void,water,all")
                .Annotation("Npgsql:Enum:keyword_type", "ancestral,composure,courtesy,covert,disguised,limited,no_attachments,pride,restricted,sincerity")
                .Annotation("Npgsql:Enum:set_name", "core_set,tears_of_amaterasu,for_honor_and_glory,into_the_forbidden_city,the_chrysanthemum_throne,fate_has_no_secrets,meditations_on_the_ephemeral,disciples_of_the_void,breath_of_the_kami,tainted_lands,the_fires_within,the_ebb_and_flow,all_and_nothing,elements_unbound,underhand_of_the_emperor,children_of_the_empire")
                .Annotation("Npgsql:Enum:side", "conflict,province,dynasty,role")
                .Annotation("Npgsql:Enum:trait", "academy,actor,air,army,banner,battle_maiden,battlefield,berserker,bushi,castle,cavalry,champion,city,commander,condition,courtier,crab,crane,creature,crown_prince,curse,daimyo,dojo,duelist,earth,elemental_master,emperor,engineer,festival,fire,follower,fort,gaijin,garden,geisha,goblin,heretic,imperial,informant,item,jade,kaiu_wall,keeper,kenshinzen,kiho,laboratory,landmark,library,lion,magistrate,maho,mantis_clan,marketplace,mask,meishodo,mine,monk,mount,mythic,omen,oni,outpost,palace,peasant,philosophy,phoenix,poison,quest,ritual,river,ronin,scholar,scorpion,scout,seal,seeker,shadow,shadowlands,shinobi,shrine,shugenja,skill,spell,spirit,storyteller,tactic,tattoo,tattooed,tea_house,technique,temple,trap,unicorn,void,water,weapon,wily_trader,yojimbo");

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Traits = table.Column<List<Trait>>(nullable: true),
                    Side = table.Column<Side>(nullable: false),
                    DeckLimit = table.Column<int>(nullable: false),
                    Clan = table.Column<Clan>(nullable: false),
                    IsUnique = table.Column<bool>(nullable: false),
                    CardType = table.Column<CardType>(nullable: false),
                    IsRestricted = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    RoleRestriction = table.Column<int>(nullable: true),
                    AllowedClans = table.Column<List<Clan>>(nullable: true),
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
                    Element = table.Column<Element>(nullable: true),
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
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Type = table.Column<KeywordType>(nullable: false),
                    Exceptions = table.Column<List<Trait>>(nullable: true),
                    Restrictions = table.Column<List<Trait>>(nullable: true),
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
                    Pack = table.Column<SetName>(nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "PrintedCards");

            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
