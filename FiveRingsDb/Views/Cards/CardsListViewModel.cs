using System.Collections.Generic;
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
                case CardType.Province:
                case CardType.Role:
                case CardType.Stronghold:
                case CardType.Holding:
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
                case CardType.Role:
                case CardType.Event:
                default:
                    return string.Empty;
            }
        }
    }
}
