using System;

namespace FiveRingsDb.Entities
{
    public class PrintedCard
    {
        public string Illustrator { get; }

        public Uri ImageUrl { get; }

        public SetName Pack { get; }

        public string Position { get; }

        public int Quantity { get; }
    }
}