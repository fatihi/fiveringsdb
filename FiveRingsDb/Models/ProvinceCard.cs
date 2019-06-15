using Newtonsoft.Json;

namespace FiveRingsDb.Models
{
    public class ProvinceCard : Card
    {
        [JsonProperty("element")]
        public Element Element { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }
    }
}