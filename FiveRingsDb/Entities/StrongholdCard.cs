namespace FiveRingsDb.Entities
{
    public class StrongholdCard : Card
    {
        public int InfluencePool { get; set; }

        public int Fate { get; set; }

        public string StrengthBonus { get; set; }

        public int Honor { get; set; }
    }
}