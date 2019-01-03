namespace FiveRingsDb.Entities
{
    public class StrongholdCard : Card
    {
        public int InfluencePool { get; private set; }
        public int Fate { get; private set; }
        public string StrengthBonus { get; private set; }
        public int Honor { get; private set; }
    }
}