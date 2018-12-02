using System;

namespace Entities
{
    public class StrongholdCard : Card
    {
        public int Strength { get; set; }
        public int StartingHonor { get; set; }
        public int FatePerRound { get; set; }
        public int Influence { get; set; }
    }
}