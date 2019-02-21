namespace FiveRingsDb.Models
{
    public class AttachmentCard : Card
    {
        public int Cost { get; set; }

        public string MilitaryBonus { get; set; }

        public string PoliticalBonus { get; set; }

        public int? InfluenceCost { get; set; }
    }
}