using Newtonsoft.Json;

namespace FiveRingsDb.Models
{
    public class HoldingCard : Card
    {
        [JsonProperty("strength_bonus")]
        public string StrengthBonus { get; set; }
    }
}