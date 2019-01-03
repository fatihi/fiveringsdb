namespace FiveRingsDb.Entities
{
    public class EventCard : Card
    {
        public int Cost { get; private set; }
        public int? InfluenceCost { get; private set; }
    }
}