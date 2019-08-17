using System.Collections.Generic;
using System.Globalization;
using System.Text;
using FiveRingsDb.Models;
using FiveRingsDb.Utils;
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
                return costCard.Cost?.ToString(CultureInfo.CurrentCulture) ?? "-";
            }

            return string.Empty;
        }

        public string GetValues(Card card)
        {
            switch (card)
            {
                case AttachmentCard attachment:
                    return GetValueString(attachment.MilitaryBonus, attachment.PoliticalBonus);
                case CharacterCard character:
                    var military = character.Military ?? "-";
                    var political = character.Political ?? "-";
                    return GetValueString(military, political, character.Glory);
                case ProvinceCard province:
                    return province.Strength;
                case StrongholdCard stronghold:
                    return GetValueString(stronghold.Honor, stronghold.Fate, stronghold.InfluencePool, stronghold.StrengthBonus);
                case HoldingCard holding:
                    return holding.StrengthBonus;
                default:
                    return string.Empty;
            }
        }

        public string GetIconClasses(Card card)
        {
            var result = new StringBuilder();

            const string hideForSmallScreensClass = "d-none d-sm-inline-block";
            result.Append(hideForSmallScreensClass).Append(" ");
            const string fontAwesomeClass = "fa";
            result.Append(fontAwesomeClass).Append(" ");
            const string fontAwesomeAlignmentClass = "fa-fw";
            result.Append(fontAwesomeAlignmentClass).Append(" ");

            var iconType = IconProvider.GetIconString(card);
            result.Append(iconType).Append(" ");

            var clanIconColor = GetClanIconColor(card.Clan);
            result.Append(clanIconColor);

            return result.ToString();
        }

        private string GetValueString(params object[] values)
        {
            return string.Join(" / ", values);
        }

        private string GetClanIconColor(Clan clan)
        {
            return "fg-dark-" + clan.ToString().ToLower(CultureInfo.CurrentCulture);
        }
    }
}
