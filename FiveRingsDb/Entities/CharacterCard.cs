namespace FiveRingsDb.Entities
{
    public class CharacterCard : Card
    {
        public int Cost { get; set; }

        public string Military { get; set; }

        public string Political { get; set; }

        public int Glory { get; set; }

        public int? InfluenceCost { get; set; }
    }
}