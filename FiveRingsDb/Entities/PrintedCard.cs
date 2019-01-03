namespace FiveRingsDb.Entities
{
    public class PrintedCard
    {
        public string Illustrator { get; private set; }
        public string ImageUrl { get; private set; }
        public SetName Pack { get; private set; }
        public string Position { get; private set; }
        public int Quantity { get; private set; }
    }
}