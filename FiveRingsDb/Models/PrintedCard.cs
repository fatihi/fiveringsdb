using System;

namespace FiveRingsDb.Models
{
    public class PrintedCard
    {
        public string Id { get; set; }

        public string Illustrator { get; set; }

        public string ImageUrl { get; set; }

        public SetName Pack { get; set; }

        public string Position { get; set; }

        public int Quantity { get; set; }
    }
}