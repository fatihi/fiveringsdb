using System.Collections.Generic;

namespace FiveRingsDb.Entities
{
    public abstract class Card
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string NameCanonical { get; set; }

        public IEnumerable<Trait> Traits { get; set; }

        public IEnumerable<Keyword> Keywords { get; set; }

        public Side Side { get; set; }

        public int DeckLimit { get; set; }

        public IEnumerable<PrintedCard> PackCards { get; set; }

        public Clan Clan { get; set; }

        public bool IsUnique { get; set; }

        public Type Type { get; set; }

        public bool IsRestricted { get; set; }

        public string Text { get; set; }

        public string TextCanonical { get; set; }

        public RoleRestriction? RoleRestriction { get; set; }
    }
}
