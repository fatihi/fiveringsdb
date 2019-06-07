using System.Collections.Generic;
using FiveRingsDb.Utils.JsonConverter;
using Newtonsoft.Json;
using static System.String;

namespace FiveRingsDb.Models
{
    [JsonConverter(typeof(CardConverter))]
    public abstract class Card
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_canocial")]
        public string NameCanonical => Empty;

        [JsonProperty("traits")]
        public List<Trait> Traits { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        [JsonProperty("side")]
        public Side Side { get; set; }

        [JsonProperty("deck_limit")]
        public int DeckLimit { get; set; }

        [JsonProperty("pack_cards")]
        public List<PrintedCard> PackCards { get; set; }

        [JsonProperty("clan")]
        public Clan Clan { get; set; }

        [JsonProperty("unicity")]
        public bool IsUnique { get; set; }

        [JsonProperty("type")]
        public CardType CardType { get; set; }

        [JsonProperty("is_restricted")]
        public bool IsRestricted { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("text_canonical")]
        public string TextCanonical => Empty;

        [JsonProperty("role_restriction")]
        public RoleRestriction? RoleRestriction { get; set; }

        [JsonProperty("allowed_clans")]
        public List<Clan> AllowedClans { get; set; }
    }
}
