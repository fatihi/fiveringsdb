using System;

namespace Entities
{
    public class CharacterCard : Card
    {
        public int Cost { get; set; }
        public int MilitarySkill { get; set; }
        public int PoliticalSkill { get; set; }
        public int Glory { get; set; }
        public int InfluenceCost { get; set; }
    }
}