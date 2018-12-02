using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class Deck
    {
        public Clan PrimaryClan { get; set; }
        public Clan SecondaryClan { get; set; }
        public string Role { get; set; }
        public StrongholdCard Stronghold { get; set; }
        public List<ProvinceCard> Provinces { get; set; }
        public List<Card> DynastyDeck { get; set; }
        public List<Card> ConflictDeck { get; set; }

        public Deck(string primaryClan, string secondaryClan, string role)
        {
            PrimaryClan = primaryClan;
            SecondaryClan = secondaryClan;
            Role = role;
            Provinces = new List<ProvinceCard>();
            DynastyDeck = new List<Card>();
            ConflictDeck = new List<Card>();
        }
    }
}