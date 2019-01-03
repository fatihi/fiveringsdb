namespace FiveRingsDb.Entities
{
    public class CharacterCard : Card
    {
        public int Cost { get; private set; }
        public string Military { get; private set; }
        public string Political { get; private set; }
        public int Glory { get; private set; }
        public int? InfluenceCost { get; private set; }
    }
}