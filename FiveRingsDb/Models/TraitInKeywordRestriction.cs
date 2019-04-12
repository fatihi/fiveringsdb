using System.Collections.Generic;

namespace FiveRingsDb.Models
{
    public class TraitInKeywordRestriction
    {
        public int TraitId { get; set; }

        public string KeywordId { get; set; }

        public Trait Trait { get; set; }

        public Keyword Keyword { get; set; }
    }
}