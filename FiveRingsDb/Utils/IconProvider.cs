using FiveRingsDb.Models;

namespace FiveRingsDb.Utils
{
    public static class IconProvider
    {
        private const string EVENT = "fa-bolt";
        private const string PROVINCE = "fa-map-marker";
        private const string ATTACHMENT = "fa-paperclip";
        private const string CHARACTER = "fa-user";
        private const string HOLDING = "fa-home";
        private const string STRONGHOLD = "fa-university";
        private const string ROLE = "fa-asterisk";

        public static string GetIconString(Card card)
        {
            switch (card)
            {
                case EventCard _:
                    return EVENT;
                case ProvinceCard _:
                    return PROVINCE;
                case AttachmentCard _:
                    return ATTACHMENT;
                case CharacterCard _:
                    return CHARACTER;
                case HoldingCard _:
                    return HOLDING;
                case StrongholdCard _:
                    return STRONGHOLD;
                case RoleCard _:
                    return ROLE;
                default:
                    return string.Empty;
            }
        }
    }
}
