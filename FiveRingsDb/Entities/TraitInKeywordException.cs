using FiveRingsDb.Entities;

namespace FiveRingsDb.Entitites
{
    public class TraitInKeywordException
    {
        public int TraitId { get; set; }

        public string KeywordId { get; set; }

        public Trait Trait { get; set; }

        public Keyword Keyword { get; set; }
    }
}