using FiveRingsDb.Models;
using FiveRingsDb.Views.Cards;
using FluentAssertions;
using NUnit.Framework;

namespace FiveRingsDb.Tests.ViewModels
{
    public class CardsListViewModelTests
    {
        [Test]
        public void GetCost_Should_ReturnCostOfCard_When_CardHasCosts()
        {
            const int cost = 2;
            var card = new CharacterCard { Cost = cost };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetCost(card);

            result.Should().Be(cost.ToString());
        }

        [Test]
        public void GetCost_Should_ReturnEmptyString_When_CardIsNotCostCard()
        {
            var card = new ProvinceCard();
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetCost(card);

            result.Should().Be(string.Empty);
        }

        [Test]
        public void GetCost_Should_ReturnDash_When_CardIsCostCardAndHasNoCosts()
        {
            var card = new AttachmentCard { Cost = null };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetCost(card);

            result.Should().Be("-");
        }

        [Test]
        public void GetValues_Should_ReturnCorrectValues_When_CardIsAttachment()
        {
            const string militaryBonus = "+2";
            const string politicalBonus = "-2";
            var card = new AttachmentCard { MilitaryBonus = militaryBonus, PoliticalBonus = politicalBonus };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetValues(card);

            result.Should().Be(militaryBonus + " / " + politicalBonus);
        }

        [Test]
        public void GetValues_Should_ReturnCorrectValues_When_CardIsCharacter()
        {
            const string military = "2";
            const string expectedPolitical = "-";
            const int glory = 1;
            var card = new CharacterCard { Military = military, Political = null, Glory = glory };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetValues(card);

            result.Should().Be(military + " / " + expectedPolitical + " / " + glory);
        }

        [Test]
        public void GetValues_Should_ReturnCorrectValues_When_CardIsProvince()
        {
            const string strength = "3";
            var card = new ProvinceCard { Strength = strength };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetValues(card);

            result.Should().Be(strength);
        }

        [Test]
        public void GetValues_Should_ReturnCorrectValues_When_CardIsStronghold()
        {
            const int honor = 11;
            const int fate = 7;
            const int influencePool = 10;
            const string strengthBonus = "+3";
            var card = new StrongholdCard { Honor = honor, Fate = fate, InfluencePool = influencePool, StrengthBonus = strengthBonus };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetValues(card);

            result.Should().Be(honor + " / " + fate + " / " + influencePool + " / " + strengthBonus);
        }

        [Test]
        public void GetValues_Should_ReturnCorrectValues_When_CardIsHolding()
        {
            const string strengthBonus = "+3";
            var card = new HoldingCard { StrengthBonus = strengthBonus };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetValues(card);

            result.Should().Be(strengthBonus);
        }

        [Test]
        public void GetIconClasses_Should_ReturnCorrectClasses_When_ClanIsUnicorn_And_TypeIsEvent()
        {
            const string expected = "d-none d-sm-inline fa fa-fw fa-bolt fg-dark-unicorn";
            var card = new EventCard { Clan = Clan.Unicorn };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetIconClasses(card);

            result.Should().Be(expected);
        }

        [Test]
        public void GetIconClasses_Should_ReturnCorrectClasses_When_ClanIsPhoenix_And_TypeIsCharacter()
        {
            const string expected = "d-none d-sm-inline fa fa-fw fa-user fg-dark-phoenix";
            var card = new CharacterCard { Clan = Clan.Phoenix };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetIconClasses(card);

            result.Should().Be(expected);
        }

        [Test]
        public void GetIconClasses_Should_ReturnCorrectClasses_When_ClanIsScorpion_And_TypeIsStronghold()
        {
            const string expected = "d-none d-sm-inline fa fa-fw fa-university fg-dark-scorpion";
            var card = new StrongholdCard { Clan = Clan.Scorpion };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetIconClasses(card);

            result.Should().Be(expected);
        }

        [Test]
        public void GetIconClasses_Should_ReturnCorrectClasses_When_ClanIsLion_And_TypeIsProvince()
        {
            const string expected = "d-none d-sm-inline fa fa-fw fa-map-marker fg-dark-lion";
            var card = new ProvinceCard { Clan = Clan.Lion };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetIconClasses(card);

            result.Should().Be(expected);
        }

        [Test]
        public void GetIconClasses_Should_ReturnCorrectClasses_When_ClanIsCrane_And_TypeIsAttachment()
        {
            const string expected = "d-none d-sm-inline fa fa-fw fa-paperclip fg-dark-crane";
            var card = new AttachmentCard { Clan = Clan.Crane };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetIconClasses(card);

            result.Should().Be(expected);
        }

        [Test]
        public void GetIconClasses_Should_ReturnCorrectClasses_When_ClanIsCrab_And_TypeIsHolding()
        {
            const string expected = "d-none d-sm-inline fa fa-fw fa-home fg-dark-crab";
            var card = new HoldingCard { Clan = Clan.Crab };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetIconClasses(card);

            result.Should().Be(expected);
        }

        [Test]
        public void GetIconClasses_Should_ReturnCorrectClasses_When_ClanIsNeutral_And_TypeIsRole()
        {
            const string expected = "d-none d-sm-inline fa fa-fw fa-asterisk fg-dark-neutral";
            var card = new RoleCard { Clan = Clan.Neutral };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetIconClasses(card);

            result.Should().Be(expected);
        }

        [Test]
        public void GetIconClasses_Should_ReturnCorrectClasses_When_ClanIsDragon_And_TypeIsRole()
        {
            const string expected = "d-none d-sm-inline fa fa-fw fa-asterisk fg-dark-dragon";
            var card = new RoleCard { Clan = Clan.Dragon };
            var viewModel = new CardsListViewModel();

            var result = viewModel.GetIconClasses(card);

            result.Should().Be(expected);
        }
    }
}
