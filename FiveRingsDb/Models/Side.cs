using System.Runtime.Serialization;

namespace FiveRingsDb.Models
{
    public enum Side
    {
        [EnumMember(Value = "conflict")]
        Conflict,
        [EnumMember(Value = "province")]
        Province,
        [EnumMember(Value = "dynasty")]
        Dynasty,
        [EnumMember(Value = "role")]
        Role
    }
}