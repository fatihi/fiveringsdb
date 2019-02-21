using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveRingsDb.Migrations
{
    public partial class EstablishFluentApiProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StrongholdCard_StrengthBonus",
                table: "Cards",
                newName: "StrongholdStrengthBonus");

            migrationBuilder.RenameColumn(
                name: "StrengthBonus",
                table: "Cards",
                newName: "HoldingStrengthBonus");

            migrationBuilder.RenameColumn(
                name: "EventCard_InfluenceCost",
                table: "Cards",
                newName: "EventInfluenceCost");

            migrationBuilder.RenameColumn(
                name: "EventCard_Cost",
                table: "Cards",
                newName: "EventCost");

            migrationBuilder.RenameColumn(
                name: "CharacterCard_InfluenceCost",
                table: "Cards",
                newName: "CharacterInfluenceCost");

            migrationBuilder.RenameColumn(
                name: "CharacterCard_Cost",
                table: "Cards",
                newName: "CharacterCost");

            migrationBuilder.RenameColumn(
                name: "InfluenceCost",
                table: "Cards",
                newName: "AttachmentInfluenceCost");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Cards",
                newName: "AttachmentCost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StrongholdStrengthBonus",
                table: "Cards",
                newName: "StrongholdCard_StrengthBonus");

            migrationBuilder.RenameColumn(
                name: "HoldingStrengthBonus",
                table: "Cards",
                newName: "StrengthBonus");

            migrationBuilder.RenameColumn(
                name: "EventInfluenceCost",
                table: "Cards",
                newName: "EventCard_InfluenceCost");

            migrationBuilder.RenameColumn(
                name: "EventCost",
                table: "Cards",
                newName: "EventCard_Cost");

            migrationBuilder.RenameColumn(
                name: "CharacterInfluenceCost",
                table: "Cards",
                newName: "CharacterCard_InfluenceCost");

            migrationBuilder.RenameColumn(
                name: "CharacterCost",
                table: "Cards",
                newName: "CharacterCard_Cost");

            migrationBuilder.RenameColumn(
                name: "AttachmentInfluenceCost",
                table: "Cards",
                newName: "InfluenceCost");

            migrationBuilder.RenameColumn(
                name: "AttachmentCost",
                table: "Cards",
                newName: "Cost");
        }
    }
}
