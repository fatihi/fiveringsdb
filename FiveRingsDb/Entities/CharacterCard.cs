namespace FiveRingsDb.Entities
{
    public class CharacterCard : Card
    {
        public int Cost { get; }

        public string Military { get; }

        public string Political { get; }

        public int Glory { get; }

        public int? InfluenceCost { get; }
    }
}