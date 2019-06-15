using System.Collections.Generic;
using System.Linq;
using FiveRingsDb.Models;
using Newtonsoft.Json;

namespace FiveRingsDb.Controllers.Api
{
    public class GetCardsResponse
    {
        [JsonProperty(PropertyName = "rrg-version")]
        public int RrgVersion { get; set; }

        public IEnumerable<Card> Records { get; set; }

        public int Size => Records.Count();

        public bool Success { get; set; }
    }
}