using System;

namespace FiveRingsDb.Entities
{
    public class PrintedCard
    {
        public string Id { get; set; }
        
        public string Illustrator { get; set; }

        public Uri ImageUrl { get; set; }

        public SetName Pack { get; set; }

        public string Position { get; set; }

        public int Quantity { get; set; }
    }
}