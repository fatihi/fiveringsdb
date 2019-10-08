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
        public List<string> Exceptions { get; set; }

        [JsonProperty("restrictions")]
        public List<string> Restrictions { get; set; }
    }
}