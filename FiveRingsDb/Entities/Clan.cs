namespace FiveRingsDb.Entities
{
    using System.Runtime.Serialization;

    public enum Clan
    {
        [EnumMember(Value = "Crab")] Crab,
        [EnumMember(Value = "Crane")] Crane,
        [EnumMember(Value = "Dragon")] Dragon,
        [EnumMember(Value = "Lion")] Lion,
        [EnumMember(Value = "Neutral")] Neutral,
        [EnumMember(Value = "Phoenix")] Phoenix,
        [EnumMember(Value = "Scorpion")] Scorpion,
        [EnumMember(Value = "Unicorn")] Unicorn
    }
}
