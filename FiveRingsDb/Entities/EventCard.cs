namespace FiveRingsDb.Entities
{
    public class EventCard : Card
    {
        public int Cost { get; set; }

        public int? InfluenceCost { get; set; }
    }
}