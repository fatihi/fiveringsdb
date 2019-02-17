using System.Runtime.Serialization;

namespace FiveRingsDb.Entities
{
    public enum Keyword
    {
        [EnumMember(Value = "ancestral")] Ancestral,
        [EnumMember(Value = "composure")] Composure,
        [EnumMember(Value = "courtesy")] Courtesy,
        [EnumMember(Value = "covert")] Covert,
        [EnumMember(Value = "disguised-bushi")] DisguisedBushi,
        [EnumMember(Value = "disguised-cavalry")] DisguisedCavalry,
        [EnumMember(Value = "limited")] Limited,
        [EnumMember(Value = "no-attachments")] NoAttachments,
        [EnumMember(Value = "no-attachments-except-monk-or-tattoo")] NoAttachmentsExceptMonkOrTattoo,
        [EnumMember(Value = "no-attachments-except-weapons")] NoAttachmentsExceptWeapons,
        [EnumMember(Value = "no-poison-attachments")] NoPoisonAttachments,
        [EnumMember(Value = "pride")] Pride,
        [EnumMember(Value = "restricted")] Restricted,
        [EnumMember(Value = "sincerity")] Sincerity
    }
}
