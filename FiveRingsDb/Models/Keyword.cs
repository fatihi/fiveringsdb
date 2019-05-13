using System.Collections.Generic;
using Newtonsoft.Json;

namespace FiveRingsDb.Models
{
    public class Keyword
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public KeywordType Type { get; set; }

        [JsonProperty("exceptions")]
        public IEnumerable<Trait> Exceptions { get; set; }

        [JsonProperty("restrictions")]
        public IEnumerable<Trait> Restrictions { get; set; }
    }
}