using System.Collections.Generic;
using System.Text;
using FiveRingsDb.Models;

namespace FiveRingsDb.Views.Cards
{
    public class CardsListViewModel
    {
        public IEnumerable<Card> Cards { get; set; }

        public string GetCost(Card card)
        {
            switch (card.CardType)
            {
                case CardType.Attachment:
                    return ((AttachmentCard)card).Cost.ToString();
                case CardType.Character:
                    return ((CharacterCard)card).Cost.ToString();
                case CardType.Event:
                    return ((EventCard)card).Cost.ToString();
                default:
                    return string.Empty;
            }
        }

        public string GetValues(Card card)
        {
            switch (card.CardType)
            {
                case CardType.Attachment:
                    var attachment = (AttachmentCard)card;
                    return attachment.MilitaryBonus + " / " + attachment.PoliticalBonus;
                case CardType.Character:
                    var character = (CharacterCard)card;
                    return character.Military + " / " + character.Political + " / " + character.Glory;
                case CardType.Province:
                    var province = (ProvinceCard)card;
                    return province.Strength;
                case CardType.Stronghold:
                    var stronghold = (StrongholdCard)card;
                    return stronghold.Honor + " / " + stronghold.Fate + " / " + stronghold.InfluencePool + " / " + stronghold.StrengthBonus;
                case CardType.Holding:
                    var holding = (HoldingCard)card;
                    return holding.StrengthBonus;
                default:
                    return string.Empty;
            }
        }

        public string GetIconClasses(Card card)
        {
            var result = new StringBuilder("hidden-sm-down fa fa-fw ");

            switch (card.CardType)
            {
                case CardType.Event:
                    result.Append("fa-bolt ");
                    break;
                case CardType.Province:
                    result.Append("fa-map-marker ");
                    break;
                case CardType.Attachment:
                    result.Append("fa-paperclip ");
                    break;
                case CardType.Character:
                    result.Append("fa-user ");
                    break;
                case CardType.Holding:
                    result.Append("fa-home ");
                    break;
                case CardType.Stronghold:
                    result.Append("fa-university ");
                    break;
                case CardType.Role:
                    result.Append("fa-asterisk ");
                    break;
            }

            return result.ToString();
        }
    }
}
