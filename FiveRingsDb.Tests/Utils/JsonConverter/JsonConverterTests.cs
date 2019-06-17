using System.Linq;
using FiveRingsDb.Models;
using FluentAssertions;
using NUnit.Framework;

namespace FiveRingsDb.Tests.Utils.JsonConverter
{
    public class JsonConverterTests
    {
        [Test]
        public void ConvertToCard_Should_Deserialize_When_CardIsEvent()
        {
            const string testCard = @"[
                {
                    ""allowed_clans"": [
                        ""phoenix""
                    ],
                    ""clan"": ""phoenix"",
                    ""cost"": 0,
                    ""deck_limit"": 3,
                    ""element"": null,
                    ""fate"": null,
                    ""glory"": null,
                    ""honor"": null,
                    ""id"": ""way-of-the-phoenix"",
                    ""influence_cost"": null,
                    ""influence_pool"": null,
                    ""is_restricted"": false,
                    ""military"": null,
                    ""military_bonus"": null,
                    ""name"": ""Way of the Phoenix"",
                    ""name_extra"": null,
                    ""political"": null,
                    ""political_bonus"": null,
                    ""role_restriction"": null,
                    ""side"": ""conflict"",
                    ""strength"": null,
                    ""strength_bonus"": null,
                    ""text"": ""<b>Action:</b> Choose a ring and an opponent – that player cannot declare conflicts of that ring's element this phase. (Max 1 per phase.)"",
                    ""traits"": [
                    ""philosophy""
                        ],
                    ""type"": ""event"",
                    ""unicity"": false
                }
            ]";
            var converter = new FiveRingsDb.Utils.JsonConverter.JsonConverter();

            var card = (EventCard)converter.ConvertToCard(testCard);

            card.Should().NotBeNull();
            card.AllowedClans.Should().HaveCount(1);
            card.AllowedClans.Should().Contain(Clan.Phoenix);
            card.Clan.Should().Be(Clan.Phoenix);
            card.Cost.Should().Be(0);
            card.DeckLimit.Should().Be(3);
            card.Id.Should().Be("way-of-the-phoenix");
            card.InfluenceCost.Should().BeNull();
            card.IsRestricted.Should().BeFalse();
            card.Name.Should().Be("Way of the Phoenix");
            card.Side.Should().Be(Side.Conflict);
            card.Text.Should()
                .Be(
                    "<b>Action:</b> Choose a ring and an opponent – that player cannot declare conflicts of that ring's element this phase. (Max 1 per phase.)");
            card.CardType.Should().Be(CardType.Event);
            card.IsUnique.Should().BeFalse();
        }

        [Test]
        public void ConvertToCard_Should_Deserialize_When_CardIsStronghold()
        {
            const string testCard = @"[
                {
                    ""allowed_clans"": [
                        ""phoenix""
                    ],
                    ""clan"": ""phoenix"",
                    ""cost"": null,
                    ""deck_limit"": 1,
                    ""element"": null,
                    ""fate"": 7,
                    ""glory"": null,
                    ""honor"": 11,
                    ""id"": ""isawa-mori-seido"",
                    ""influence_cost"": null,
                    ""influence_pool"": 10,
                    ""is_restricted"": false,
                    ""military"": null,
                    ""military_bonus"": null,
                    ""name"": ""Isawa Mori Seidō"",
                    ""name_extra"": null,
                    ""political"": null,
                    ""political_bonus"": null,
                    ""role_restriction"": null,
                    ""side"": ""province"",
                    ""strength"": null,
                    ""strength_bonus"": ""+2"",
                    ""text"": ""<b>Action:</b> Bow this stronghold, choose a character – that character gets +2 glory until the end of the phase."",
                    ""traits"": [
                        ""shrine""
                    ],
                    ""type"": ""stronghold"",
                    ""unicity"": true
                }
            ]";
            var converter = new FiveRingsDb.Utils.JsonConverter.JsonConverter();

            var card = (StrongholdCard)converter.ConvertToCard(testCard);

            card.Should().NotBeNull();
            card.AllowedClans.Should().HaveCount(1);
            card.AllowedClans.Should().Contain(Clan.Phoenix);
            card.Clan.Should().Be(Clan.Phoenix);
            card.DeckLimit.Should().Be(1);
            card.Fate.Should().Be(7);
            card.Honor.Should().Be(11);
            card.Id.Should().Be("isawa-mori-seido");
            card.InfluencePool.Should().Be(10);
            card.IsRestricted.Should().BeFalse();
            card.Name.Should().Be("Isawa Mori Seidō");
            card.RoleRestriction.Should().BeNull();
            card.Side.Should().Be(Side.Province);
            card.StrengthBonus.Should().Be("+2");
            card.Text.Should()
                .Be(
                    "<b>Action:</b> Bow this stronghold, choose a character – that character gets +2 glory until the end of the phase.");
            card.Traits.Should().HaveCount(1);
            card.Traits.First().Should().Be(Trait.Shrine);
            card.CardType.Should().Be(CardType.Stronghold);
            card.IsUnique.Should().BeTrue();
        }

        [Test]
        public void ConvertToCard_Should_Deserialize_When_CardIsAttachment()
        {
            const string testCard = @"[
                {
                    ""allowed_clans"": [
                        ""crab"",
                        ""crane"",
                        ""dragon"",
                        ""lion"",
                        ""phoenix"",
                        ""scorpion"",
                        ""unicorn""
                    ],
                    ""clan"": ""crab"",
                    ""cost"": 2,
                    ""deck_limit"": 3,
                    ""element"": null,
                    ""fate"": null,
                    ""glory"": null,
                    ""honor"": null,
                    ""id"": ""jade-tetsubo"",
                    ""influence_cost"": 2,
                    ""influence_pool"": null,
                    ""is_restricted"": false,
                    ""military"": null,
                    ""military_bonus"": ""+3"",
                    ""name"": ""Jade Tetsubō"",
                    ""name_extra"": null,
                    ""political"": null,
                    ""political_bonus"": ""+0"",
                    ""role_restriction"": null,
                    ""side"": ""conflict"",
                    ""strength"": null,
                    ""strength_bonus"": null,
                    ""text"": ""Attach to a character you control. Restricted.\n<b>Action:</b> While attached character is participating in a conflict, bow this attachment. Choose a participating character with lower [conflict-military] skill than attached character – return all fate on that character to its owner's fate pool."",
                    ""traits"": [
                        ""jade"",
                        ""weapon""
                    ],
                    ""type"": ""attachment"",
                    ""unicity"": false
                }
            ]";
            var converter = new FiveRingsDb.Utils.JsonConverter.JsonConverter();

            var card = (AttachmentCard)converter.ConvertToCard(testCard);

            card.Should().NotBeNull();
            card.AllowedClans.Should().HaveCount(7);
            card.AllowedClans.Should().Contain(Clan.Crab);
            card.AllowedClans.Should().Contain(Clan.Crane);
            card.AllowedClans.Should().Contain(Clan.Dragon);
            card.AllowedClans.Should().Contain(Clan.Lion);
            card.AllowedClans.Should().Contain(Clan.Phoenix);
            card.AllowedClans.Should().Contain(Clan.Scorpion);
            card.AllowedClans.Should().Contain(Clan.Unicorn);
            card.Clan.Should().Be(Clan.Crab);
            card.Cost.Should().Be(2);
            card.DeckLimit.Should().Be(3);
            card.Id.Should().Be("jade-tetsubo");
            card.InfluenceCost.Should().Be(2);
            card.IsRestricted.Should().BeFalse();
            card.MilitaryBonus.Should().Be("+3");
            card.Name.Should().Be("Jade Tetsubō");
            card.PoliticalBonus.Should().Be("+0");
            card.RoleRestriction.Should().BeNull();
            card.Side.Should().Be(Side.Conflict);
            card.Text.Should()
                .Be(
                    "Attach to a character you control. Restricted.\n<b>Action:</b> While attached character is participating in a conflict, bow this attachment. Choose a participating character with lower [conflict-military] skill than attached character – return all fate on that character to its owner's fate pool.");
            card.Traits.Should().HaveCount(2);
            card.Traits.Should().Contain(Trait.Jade);
            card.Traits.Should().Contain(Trait.Weapon);
            card.CardType.Should().Be(CardType.Attachment);
            card.IsUnique.Should().Be(false);
        }

        [Test]
        public void ConvertToCard_Should_Deserialize_When_CardIsCharacter()
        {
            const string testCard = @"[
                {
                    ""allowed_clans"": [
                        ""unicorn""
                    ],
                    ""clan"": ""unicorn"",
                    ""cost"": 5,
                    ""deck_limit"": 3,
                    ""element"": null,
                    ""fate"": null,
                    ""glory"": 2,
                    ""honor"": null,
                    ""id"": ""shinjo-altansarnai"",
                    ""influence_cost"": null,
                    ""influence_pool"": null,
                    ""is_restricted"": false,
                    ""military"": ""5"",
                    ""military_bonus"": null,
                    ""name"": ""Shinjo Altansarnai"",
                    ""name_extra"": null,
                    ""political"": ""4"",
                    ""political_bonus"": null,
                    ""role_restriction"": null,
                    ""side"": ""dynasty"",
                    ""strength"": null,
                    ""strength_bonus"": null,
                    ""text"": ""<b>Reaction:</b> After you break a province during a [conflict-military] conflict in which this character is participating, your opponent chooses a character he or she controls – discard that character."",
                    ""traits"": [
                        ""bushi"",
                        ""cavalry"",
                        ""champion""
                    ],
                    ""type"": ""character"",
                    ""unicity"": true
                }
            ]";
            var converter = new FiveRingsDb.Utils.JsonConverter.JsonConverter();

            var card = (CharacterCard)converter.ConvertToCard(testCard);

            card.Should().NotBeNull();
            card.AllowedClans.Should().HaveCount(1);
            card.AllowedClans.Should().Contain(Clan.Unicorn);
            card.Clan.Should().Be(Clan.Unicorn);
            card.Cost.Should().Be(5);
            card.DeckLimit.Should().Be(3);
            card.Glory.Should().Be(2);
            card.Id.Should().Be("shinjo-altansarnai");
            card.IsRestricted.Should().BeFalse();
            card.Military.Should().Be("5");
            card.Name.Should().Be("Shinjo Altansarnai");
            card.Political.Should().Be("4");
            card.RoleRestriction.Should().BeNull();
            card.Side.Should().Be(Side.Dynasty);
            card.Text.Should()
                .Be(
                    "<b>Reaction:</b> After you break a province during a [conflict-military] conflict in which this character is participating, your opponent chooses a character he or she controls – discard that character.");
            card.Traits.Should().HaveCount(3);
            card.Traits.Should().Contain(Trait.Bushi);
            card.Traits.Should().Contain(Trait.Cavalry);
            card.Traits.Should().Contain(Trait.Champion);
            card.CardType.Should().Be(CardType.Character);
            card.IsUnique.Should().BeTrue();
        }

        [Test]
        public void ConvertToCard_Should_Deserialize_When_CardIsHolding()
        {
            const string testCard = @"[
                {
                    ""allowed_clans"": [
                        ""crab"",
                        ""crane"",
                        ""dragon"",
                        ""lion"",
                        ""phoenix"",
                        ""scorpion"",
                        ""unicorn""
                    ],
                    ""clan"": ""neutral"",
                    ""cost"": null,
                    ""deck_limit"": 3,
                    ""element"": null,
                    ""fate"": null,
                    ""glory"": null,
                    ""honor"": null,
                    ""id"": ""favorable-ground"",
                    ""influence_cost"": null,
                    ""influence_pool"": null,
                    ""is_restricted"": false,
                    ""military"": null,
                    ""military_bonus"": null,
                    ""name"": ""Favorable Ground"",
                    ""name_extra"": null,
                    ""political"": null,
                    ""political_bonus"": null,
                    ""role_restriction"": null,
                    ""side"": ""dynasty"",
                    ""strength"": null,
                    ""strength_bonus"": ""+1"",
                    ""text"": ""<b>Action:</b> During a conflict, sacrifice this holding. Choose a character you control – move that character to the conflict or home from the conflict."",
                    ""traits"": [
                        ""battlefield""
                    ],
                    ""type"": ""holding"",
                    ""unicity"": false
                }
            ]";
            var converter = new FiveRingsDb.Utils.JsonConverter.JsonConverter();

            var card = (HoldingCard)converter.ConvertToCard(testCard);

            card.Should().NotBeNull();
            card.AllowedClans.Should().HaveCount(7);
            card.AllowedClans.Should().Contain(Clan.Crab);
            card.AllowedClans.Should().Contain(Clan.Crane);
            card.AllowedClans.Should().Contain(Clan.Dragon);
            card.AllowedClans.Should().Contain(Clan.Lion);
            card.AllowedClans.Should().Contain(Clan.Phoenix);
            card.AllowedClans.Should().Contain(Clan.Scorpion);
            card.AllowedClans.Should().Contain(Clan.Unicorn);
            card.Clan.Should().Be(Clan.Neutral);
            card.DeckLimit.Should().Be(3);
            card.Id.Should().Be("favorable-ground");
            card.IsRestricted.Should().BeFalse();
            card.Name.Should().Be("Favorable Ground");
            card.RoleRestriction.Should().BeNull();
            card.Side.Should().Be(Side.Dynasty);
            card.StrengthBonus.Should().Be("+1");
            card.Text.Should()
                .Be(
                    "<b>Action:</b> During a conflict, sacrifice this holding. Choose a character you control – move that character to the conflict or home from the conflict.");
            card.Traits.Should().HaveCount(1);
            card.Traits.Should().Contain(Trait.Battlefield);
            card.CardType.Should().Be(CardType.Holding);
            card.IsUnique.Should().BeFalse();
        }

        [Test]
        public void ConvertToCard_Should_Deserialize_When_CardIsProvince()
        {
            const string testCard = @"[
                {
                    ""allowed_clans"": [
                        ""scorpion""
                    ],
                    ""clan"": ""scorpion"",
                    ""cost"": null,
                    ""deck_limit"": 1,
                    ""element"": ""void"",
                    ""fate"": null,
                    ""glory"": null,
                    ""honor"": null,
                    ""id"": ""brother-s-gift-dojo"",
                    ""influence_cost"": null,
                    ""influence_pool"": null,
                    ""is_restricted"": false,
                    ""military"": null,
                    ""military_bonus"": null,
                    ""name"": ""Brother’s Gift Dōjō"",
                    ""name_extra"": null,
                    ""political"": null,
                    ""political_bonus"": null,
                    ""role_restriction"": null,
                    ""side"": ""province"",
                    ""strength"": ""4"",
                    ""strength_bonus"": null,
                    ""text"": ""<b>Action:</b> During a conflict, lose 1 honor and choose a participating character you control – move that character home. (Limit twice per round.)"",
                    ""traits"": [
                        ""dojo""
                    ],
                    ""type"": ""province"",
                    ""unicity"": true
                }
            ]";
            var converter = new FiveRingsDb.Utils.JsonConverter.JsonConverter();

            var card = (ProvinceCard)converter.ConvertToCard(testCard);

            card.Should().NotBeNull();
            card.AllowedClans.Should().HaveCount(1);
            card.AllowedClans.Should().Contain(Clan.Scorpion);
            card.Clan.Should().Be(Clan.Scorpion);
            card.DeckLimit.Should().Be(1);
            card.Element.Should().Be(Element.Void);
            card.Id.Should().Be("brother-s-gift-dojo");
            card.IsRestricted.Should().BeFalse();
            card.Name.Should().Be("Brother’s Gift Dōjō");
            card.RoleRestriction.Should().BeNull();
            card.Side.Should().Be(Side.Province);
            card.Strength.Should().Be("4");
            card.Text.Should()
                .Be(
                    "<b>Action:</b> During a conflict, lose 1 honor and choose a participating character you control – move that character home. (Limit twice per round.)");
            card.Traits.Should().HaveCount(1);
            card.Traits.Should().Contain(Trait.Dojo);
            card.CardType.Should().Be(CardType.Province);
            card.IsUnique.Should().BeTrue();
        }

        [Test]
        public void ConvertToCard_Should_Deserialize_When_CardIsRole()
        {
            const string testCard = @"[
                {
                    ""allowed_clans"": [
                        ""crab"",
                        ""crane"",
                        ""dragon"",
                        ""lion"",
                        ""phoenix"",
                        ""scorpion"",
                        ""unicorn""
                    ],
                    ""clan"": ""neutral"",
                    ""cost"": null,
                    ""deck_limit"": 1,
                    ""element"": null,
                    ""fate"": null,
                    ""glory"": null,
                    ""honor"": null,
                    ""id"": ""seeker-of-void"",
                    ""influence_cost"": null,
                    ""influence_pool"": null,
                    ""is_restricted"": false,
                    ""military"": null,
                    ""military_bonus"": null,
                    ""name"": ""Seeker of Void"",
                    ""name_extra"": null,
                    ""political"": null,
                    ""political_bonus"": null,
                    ""role_restriction"": null,
                    ""side"": ""role"",
                    ""strength"": null,
                    ""strength_bonus"": null,
                    ""text"": ""You may replace 1 province of any element with an additional [element-void] province while deckbuilding.\n<b>Reaction:</b> After a [element-void] province you control is revealed – gain 1 fate."",
                    ""traits"": [
                        ""seeker"",
                        ""void""
                    ],
                    ""type"": ""role"",
                    ""unicity"": false
                }
            ]";
            var converter = new FiveRingsDb.Utils.JsonConverter.JsonConverter();

            var card = (RoleCard)converter.ConvertToCard(testCard);

            card.Should().NotBeNull();
            card.AllowedClans.Should().HaveCount(7);
            card.AllowedClans.Should().Contain(Clan.Crab);
            card.AllowedClans.Should().Contain(Clan.Crane);
            card.AllowedClans.Should().Contain(Clan.Dragon);
            card.AllowedClans.Should().Contain(Clan.Lion);
            card.AllowedClans.Should().Contain(Clan.Phoenix);
            card.AllowedClans.Should().Contain(Clan.Scorpion);
            card.AllowedClans.Should().Contain(Clan.Unicorn);
            card.Clan.Should().Be(Clan.Neutral);
            card.DeckLimit.Should().Be(1);
            card.Id.Should().Be("seeker-of-void");
            card.IsRestricted.Should().BeFalse();
            card.Name.Should().Be("Seeker of Void");
            card.RoleRestriction.Should().BeNull();
            card.Side.Should().Be(Side.Role);
            card.Text.Should()
                .Be(
                    "You may replace 1 province of any element with an additional [element-void] province while deckbuilding.\n<b>Reaction:</b> After a [element-void] province you control is revealed – gain 1 fate.");
            card.Traits.Should().HaveCount(2);
            card.Traits.Should().Contain(Trait.Seeker);
            card.Traits.Should().Contain(Trait.Void);
            card.CardType.Should().Be(CardType.Role);
            card.IsUnique.Should().BeFalse();
        }
    }
}
