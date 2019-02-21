using System.Runtime.Serialization;

namespace FiveRingsDb.Models
{
    public enum KeywordType
    {
        [EnumMember(Value = "ancestral")] Ancestral,
        [EnumMember(Value = "composure")] Composure,
        [EnumMember(Value = "courtesy")] Courtesy,
        [EnumMember(Value = "covert")] Covert,
        [EnumMember(Value = "disguised")] Disguised,
        [EnumMember(Value = "limited")] Limited,
        [EnumMember(Value = "no-attachments")] NoAttachments,
        [EnumMember(Value = "pride")] Pride,
        [EnumMember(Value = "restricted")] Restricted,
        [EnumMember(Value = "sincerity")] Sincerity
    }
}