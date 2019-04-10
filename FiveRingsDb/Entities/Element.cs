using System.Runtime.Serialization;

namespace FiveRingsDb.Entities
{
    public enum Element
    {
        [EnumMember(Value = "air")]
        Air,
        [EnumMember(Value = "earth")]
        Earth,
        [EnumMember(Value = "fire")]
        Fire,
        [EnumMember(Value = "void")]
        Void,
        [EnumMember(Value = "water")]
        Water,
        [EnumMember(Value = "all")]
        All
    }
}