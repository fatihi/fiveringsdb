using System.Collections.Generic;

namespace FiveRingsDb.Models
{
    public class Keyword
    {
        public string Id { get; set; }

        public KeywordType Type { get; set; }

        public IEnumerable<Trait> Exceptions { get; set; }

        public IEnumerable<Trait> Restrictions { get; set; }
    }
}