using System.Runtime.Serialization;

namespace FiveRingsDb.Models
{
    public enum RoleRestriction
    {
        [EnumMember(Value = "keeper")]
        Keeper,
        [EnumMember(Value = "seeker")]
        Seeker,
        [EnumMember(Value = "air")]
        Air,
        [EnumMember(Value = "earth")]
        Earth,
        [EnumMember(Value = "fire")]
        Fire,
        [EnumMember(Value = "void")]
        Void,
        [EnumMember(Value = "water")]
        Water
    }
}