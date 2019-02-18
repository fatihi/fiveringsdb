using System.Collections.Generic;

namespace FiveRingsDb.Entities
{
    /// <summary>
    /// This class represents both simple and more complex keywords. Simple keywords only have the <see cref="Type"/>
    /// member set. More complex keywords, like <see cref="KeywordType.NoAttachments"/> or
    /// <see cref="KeywordType.Disguised"/>, require either additional exceptions (<see cref="Exceptions"/>) or
    /// restrictions (<see cref="Restrictions"/>).
    /// </summary>
    public sealed class Keyword
    {
        /// <summary>
        /// Actual type of the keyword, as they are defined in the <i>Rules Reference Guide</i> by FFG (<seealso cref="KeywordType"/>).
        /// </summary>
        public KeywordType Type { get; set; }

        /// <summary>
        /// List of <see cref="Trait"/>s that act as an exception for the current keyword.
        /// </summary>
        /// <example>
        /// The keyword <see cref="KeywordType.NoAttachments"/> can contain exceptions,
        /// e.g. <i>No attachments except <b>Weapon</b></i>.
        /// </example>
        public IEnumerable<Trait> Exceptions { get; set; } = new List<Trait>();

        /// <summary>
        /// List of <see cref="Trait"/>s that act as a restriction for the current keyword.
        /// </summary>
        /// <example>
        /// The keyword <see cref="KeywordType.Disguised"/> always has at least one trait that it is restricted to,
        /// e.g. <i>Disguised <b>Bushi</b></i>.<br /><br />
        /// In addition, the keyword <see cref="KeywordType.NoAttachments"/> can be restricted to several traits,
        /// e.g. <i>No <b>Poison</b> attachments</i>.
        /// </example>
        public IEnumerable<Trait> Restrictions { get; set; } = new List<Trait>();
    }
}