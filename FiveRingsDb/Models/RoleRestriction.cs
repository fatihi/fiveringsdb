using System.Runtime.Serialization;

namespace FiveRingsDb.Models
{
    /// <summary>
    /// Deck building restrictions based on the role of the player.
    /// </summary>
    public enum RoleRestriction
    {
        /// <summary>
        /// Keeper roles only.
        /// </summary>
        [EnumMember(Value = "keeper")]
        Keeper,

        /// <summary>
        /// Seeker roles only.
        /// </summary>
        [EnumMember(Value = "seeker")]
        Seeker,

        /// <summary>
        /// Air roles only.
        /// </summary>
        [EnumMember(Value = "air")]
        Air,

        /// <summary>
        /// Earth roles only.
        /// </summary>
        [EnumMember(Value = "earth")]
        Earth,

        /// <summary>
        /// Fire roles only.
        /// </summary>
        [EnumMember(Value = "fire")]
        Fire,

        /// <summary>
        /// Void roles only.
        /// </summary>
        [EnumMember(Value = "void")]
        Void,

        /// <summary>
        /// Water roles only.
        /// </summary>
        [EnumMember(Value = "water")]
        Water
    }
}