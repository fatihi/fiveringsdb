using Newtonsoft.Json;

namespace FiveRingsDb.Models
{
    public class StrongholdCard : Card
    {
        [JsonProperty("influence_pool")]
        public int InfluencePool { get; set; }

        [JsonProperty("fate")]
        public int Fate { get; set; }

        [JsonProperty("strength_bonus")]
        public string StrengthBonus { get; set; }

        [JsonProperty("honor")]
        public int Honor { get; set; }
    }
}