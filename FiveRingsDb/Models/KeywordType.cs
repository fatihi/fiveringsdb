using System.Runtime.Serialization;

namespace FiveRingsDb.Models
{
    /// <summary>
    /// Types of Keywords.
    /// </summary>
    public enum KeywordType
    {
        /// <summary>
        /// Ancestral is a keyword found on attachments.
        /// When the card to which the ancestral card is attached to leaves play, then it is returned to its owner's hand instead of being discarded as well.
        /// </summary>
        [EnumMember(Value = "ancestral")]
        Ancestral,

        /// <summary>
        /// Composure is a keyword found on characters.
        /// A character with this keyword gains an additional ability while its controller's honor bid is lower than that of one of his or her opponent.
        /// </summary>
        [EnumMember(Value = "composure")]
        Composure,

        /// <summary>
        /// Courtesy is a keyword found on characters.
        /// When a character with courtesy leaves play, then the owner gains 1 fate.
        /// </summary>
        [EnumMember(Value = "courtesy")]
        Courtesy,

        /// <summary>
        /// Covert is a keyword found on characters.
        /// When this character is declared as an attacker in a conflict, you may choose a character that does not have covert. That character cannot be declared as a defender for this conflict during the "declare defenders" step.
        /// </summary>
        [EnumMember(Value = "covert")]
        Covert,

        /// <summary>
        /// Disguised is a keyword found on characters.
        /// At any time you could play a character from your hand during the conflict phase, choose any non-unique character that matches the restrictions listed on the disguised character. Put the disguised character into play, unbowed, in the same location that the chosen character is, reducing the cost to play the disguised character from your province or your hand by the printed cost of the chosen character. The disguised character can't have additional fate put on them when they're played in this way. Move all attachments and tokens (including fate tokens and status tokens) from the chosen character to the disguised character. Discard the chosen character from play.
        /// </summary>
        [EnumMember(Value = "disguised")]
        Disguised,

        /// <summary>
        /// A player cannot play more than one limited card per round.
        /// </summary>
        [EnumMember(Value = "limited")]
        Limited,

        /// <summary>
        /// A character with the No Attachments keyword cannot have any attachments.
        /// </summary>
        [EnumMember(Value = "no-attachments")]
        NoAttachments,

        /// <summary>
        /// Pride is a keyword found on characters.
        /// A character with this keyword gets honored when winning a conflict and dishonored when losing a conflict.
        /// </summary>
        [EnumMember(Value = "pride")]
        Pride,

        /// <summary>
        /// Restricted is a keyword found on attachments.
        /// A character cannot equip more than two restricted attachments.
        /// </summary>
        [EnumMember(Value = "restricted")]
        Restricted,

        /// <summary>
        /// Sincerity is a keyword found on characters.
        /// When a character with this keyword leaves play, then the owner draws 1 card.
        /// </summary>
        [EnumMember(Value = "sincerity")]
        Sincerity
    }
}