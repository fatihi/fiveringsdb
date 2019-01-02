namespace FiveRingsDb.Entities
{
    using System.Collections.Generic;

    public abstract class Card
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string NameCanonical { get; private set; }
        public IEnumerable<Trait> Traits { get; private set; }
        public Side Side { get; private set; }
        public int DeckLimit { get; private set; }
        public IEnumerable<PrintedCard> PackCards { get; private set; }
        public Clan Clan { get; private set; }
        public bool IsUnique { get; private set; }
        public Type Type { get; private set; }
        public bool IsRestricted { get; private set; }
        public string Text { get; private set; }
        public string TextCanonical { get; private set; }
    }
}
