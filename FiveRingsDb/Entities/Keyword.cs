using System.Collections.Generic;

namespace FiveRingsDb.Entities
{
    public sealed class Keyword
    {
        public KeywordType Type { get; set; }

        public IEnumerable<Trait> Exceptions { get; set; } = new List<Trait>();

        public IEnumerable<Trait> Restrictions { get; set; } = new List<Trait>();
    }
}