using System.Collections.Generic;

namespace FiveRingsDb.Entities
{
    public abstract class Card
    {
        public string Id { get; }

        public string Name { get; }

        public string NameCanonical { get; }

        public IEnumerable<Trait> Traits { get; }

        public IEnumerable<Keyword> Keywords { get; }

        public Side Side { get; }

        public int DeckLimit { get; }

        public IEnumerable<PrintedCard> PackCards { get; }

        public Clan Clan { get; }

        public bool IsUnique { get; }

        public Type Type { get; }

        public bool IsRestricted { get; }

        public string Text { get; }

        public string TextCanonical { get; }

        public RoleRestriction? RoleRestriction { get; }
    }
}
