using Newtonsoft.Json;

namespace FiveRingsDb.Models
{
    public class CharacterCard : Card, ICostCard, IInfluenceCostCard
    {
        [JsonProperty("cost")]
        public int? Cost { get; set; }

        [JsonProperty("military")]
        public string Military { get; set; }

        [JsonProperty("political")]
        public string Political { get; set; }

        [JsonProperty("glory")]
        public int Glory { get; set; }

        [JsonProperty("influence_cost")]
        public int? InfluenceCost { get; set; }
    }
}