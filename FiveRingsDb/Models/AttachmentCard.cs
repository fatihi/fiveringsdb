using Newtonsoft.Json;

namespace FiveRingsDb.Models
{
    public class AttachmentCard : Card
    {
        [JsonProperty("cost")]
        public int? Cost { get; set; }

        [JsonProperty("military_bonus")]
        public string MilitaryBonus { get; set; }

        [JsonProperty("political_bonus")]
        public string PoliticalBonus { get; set; }

        [JsonProperty("influence_cost")]
        public int? InfluenceCost { get; set; }
    }
}