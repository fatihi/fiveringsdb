using FiveRingsDb.Entitites;
using System.Collections.Generic;

namespace FiveRingsDb.Entities
{
    public class Keyword
    {
        public string Id { get; set; }
        
        public KeywordType Type { get; set; }

        public ICollection<TraitInKeywordException> TraitInKeywordExceptions { get; set; }

        public ICollection<TraitInKeywordRestriction> TraitInKeywordRestrictions { get; set; }
    }
}