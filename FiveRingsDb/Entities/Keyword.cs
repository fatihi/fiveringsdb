using System.Collections.Generic;

namespace FiveRingsDb.Entities
{
    public class Keyword
    {
        public KeywordType Type { get; set; }

        public IEnumerable<Trait> Exceptions { get; set; }

        public IEnumerable<Trait> Restrictions { get; set; }
    }
}