using FiveRingsDb.Entitites;
using System.Collections.Generic;

namespace FiveRingsDb.Entities
{
    public class Trait
    {
        public int Id { get; set; }

        public TraitEnum TraitEnum { get; set; }

        public virtual ICollection<TraitOnCard> TraitsOnCards { get; set; }

        public virtual ICollection<TraitInKeywordRestriction> TraitsInKeywordRestrictions { get; set; }

        public virtual ICollection<TraitInKeywordException> TraitsInKeywordExceptions { get; set; }
    }
}