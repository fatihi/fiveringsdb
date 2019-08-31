using System.Collections.Generic;
using FiveRingsDb.Utils;
using FiveRingsDb.Utils.JsonConverter;
using Newtonsoft.Json;

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
        public string NameCanonical => Name.ToCanonical();

        [JsonProperty("traits")]
        public List<string> Traits { get; set; }

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
        public string TextCanonical => Text.ToCanonical();

        [JsonProperty("role_restriction")]
        public RoleRestriction? RoleRestriction { get; set; }

        [JsonProperty("allowed_clans")]
        public List<Clan> AllowedClans { get; set; }
    }
}
