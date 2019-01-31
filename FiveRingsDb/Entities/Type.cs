using System.Runtime.Serialization;

namespace FiveRingsDb.Entities
{
    public enum Type
    {
        [EnumMember(Value = "event")]
        Event,
        [EnumMember(Value = "province")]
        Province,
        [EnumMember(Value = "attachment")]
        Attachment,
        [EnumMember(Value = "character")]
        Character,
        [EnumMember(Value = "holding")]
        Holding,
        [EnumMember(Value = "stronghold")]
        Stronghold,
        [EnumMember(Value = "role")]
        Role
    }
}