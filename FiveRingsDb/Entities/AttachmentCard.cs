namespace FiveRingsDb.Entities
{
    public class AttachmentCard : Card
    {
        public int Cost { get; private set; }
        public string MilitaryBonus { get; private set; }
        public string PoliticalBonus { get; private set; }
        public int? InfluenceCost { get; private set; }
    }
}