using Newtonsoft.Json;

namespace FiveRingsDb.Models
{
    public class EventCard : Card, ICostCard
    {
        [JsonProperty("cost")]
        public int? Cost { get; set; }

        [JsonProperty("influence_cost")]
        public int? InfluenceCost { get; set; }
    }
}