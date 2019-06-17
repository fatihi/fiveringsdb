using System.Runtime.Serialization;

namespace FiveRingsDb.Models
{
    /// <summary>
    /// Places that cards can be placed on the field.
    /// </summary>
    public enum Side
    {
        /// <summary>
        /// Represents cards in the conflict deck.
        /// </summary>
        [EnumMember(Value = "conflict")]
        Conflict,

        /// <summary>
        /// Represents cards in the provinces. This includes strongholds.
        /// </summary>
        [EnumMember(Value = "province")]
        Province,

        /// <summary>
        /// Represents cards in the dynasty deck.
        /// </summary>
        [EnumMember(Value = "dynasty")]
        Dynasty,

        /// <summary>
        /// Represents role cards.
        /// </summary>
        [EnumMember(Value = "role")]
        Role
    }
}