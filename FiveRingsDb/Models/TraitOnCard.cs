using System.Collections.Generic;

namespace FiveRingsDb.Models
{
    public class TraitOnCard
    {
        public int TraitId { get; set; }

        public string CardId { get; set; }

        public Trait Trait { get; set; }

        public Card Card { get; set; }
    }
}