using Newtonsoft.Json;

namespace FiveRingsDb.Models
{
    public class PrintedCard
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("illustrator")]
        public string Illustrator { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("pack")]
        public string Pack { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}