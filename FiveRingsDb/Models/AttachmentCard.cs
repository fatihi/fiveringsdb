namespace FiveRingsDb.Models
{
    public class AttachmentCard : Card
    {
        public int Cost { get; }

        public string MilitaryBonus { get; }

        public string PoliticalBonus { get; }

        public int? InfluenceCost { get; }
    }
}