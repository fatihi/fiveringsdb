using System.Collections.Generic;
using System.Globalization;
using System.Text;
using FiveRingsDb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FiveRingsDb.Views.Cards
{
    public class CardsListViewModel : PageModel
    {
        public IEnumerable<Card> Cards { get; set; }

        public string GetCost(Card card)
        {
            if (card is ICostCard costCard)
            {
                return costCard.Cost == null ? "-" : costCard.Cost.ToString();
            }

            return string.Empty;
        }

        public string GetValues(Card card)
        {
            switch (card)
            {
                case AttachmentCard attachment:
                    return attachment.MilitaryBonus + " / " + attachment.PoliticalBonus;
                case CharacterCard character:
                    return character.Military + " / " + character.Political + " / " + character.Glory;
                case ProvinceCard province:
                    return province.Strength;
                case StrongholdCard stronghold:
                    return stronghold.Honor + " / " + stronghold.Fate + " / " + stronghold.InfluencePool + " / " + stronghold.StrengthBonus;
                case HoldingCard holding:
                    return holding.StrengthBonus;
                default:
                    return string.Empty;
            }
        }

        public string GetIconClasses(Card card)
        {
            var result = new StringBuilder("hidden-sm-down fa fa-fw ");

            var iconType = GetIconType(card.CardType);
            result.Append(iconType).Append(" ");

            var clanIconColor = GetClanIconColor(card.Clan);
            result.Append(clanIconColor);

            return result.ToString();
        }

        private string GetClanIconColor(Clan clan)
        {
            return "fg-dark-" + clan.ToString().ToLower(CultureInfo.CurrentCulture);
        }

        private string GetIconType(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.Event:
                    return "fa-bolt";
                case CardType.Province:
                    return "fa-map-marker";
                case CardType.Attachment:
                    return "fa-paperclip";
                case CardType.Character:
                    return "fa-user";
                case CardType.Holding:
                    return "fa-home";
                case CardType.Stronghold:
                    return "fa-university";
                case CardType.Role:
                    return "fa-asterisk";
                default:
                    return string.Empty;
            }
        }
    }
}
