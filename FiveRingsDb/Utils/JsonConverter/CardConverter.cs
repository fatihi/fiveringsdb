using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FiveRingsDb.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Type = FiveRingsDb.Models.Type;

namespace FiveRingsDb.Utils.JsonConverter
{
    public class CardConverter : Newtonsoft.Json.JsonConverter
    {
        private static readonly JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new SpecifiedCardConverter() };

        public override bool CanWrite => false;

        public override bool CanConvert(System.Type objectType) => objectType == typeof(Card);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = GetJsonObject(reader);
            var cardType = GetCardType(jsonObject);

            return DeserializeObject(cardType, jsonObject);
        }

        private JArray GetJsonObject(JsonReader reader)
        {
            return JArray.Load(reader);
        }

        private Type GetCardType(JToken jsonObject)
        {
            var objectTypeString = jsonObject.First["type"].Value<string>();
            var parseSucceeded = Enum.TryParse(objectTypeString, true, out Type cardType);

            if (!parseSucceeded)
            {
                throw new FileParsingException();
            }

            return cardType;
        }

        private Card DeserializeObject(Type cardType, IEnumerable jsonObject)
        {
            switch (cardType)
            {
                case Type.Attachment:
                    return JsonConvert.DeserializeObject<IEnumerable<AttachmentCard>>(jsonObject.ToString(), SpecifiedSubclassConversion).First();
                case Type.Character:
                    return JsonConvert.DeserializeObject<IEnumerable<CharacterCard>>(jsonObject.ToString(), SpecifiedSubclassConversion).First();
                case Type.Event:
                    return JsonConvert.DeserializeObject<IEnumerable<EventCard>>(jsonObject.ToString(), SpecifiedSubclassConversion).First();
                case Type.Holding:
                    return JsonConvert.DeserializeObject<IEnumerable<HoldingCard>>(jsonObject.ToString(), SpecifiedSubclassConversion).First();
                case Type.Province:
                    return JsonConvert.DeserializeObject<IEnumerable<ProvinceCard>>(jsonObject.ToString(), SpecifiedSubclassConversion).First();
                case Type.Role:
                    return JsonConvert.DeserializeObject<IEnumerable<RoleCard>>(jsonObject.ToString(), SpecifiedSubclassConversion).First();
                case Type.Stronghold:
                    return JsonConvert.DeserializeObject<IEnumerable<StrongholdCard>>(jsonObject.ToString(), SpecifiedSubclassConversion).First();
                default:
                    throw new CardTypeNotImplementedException();
            }
        }
    }
}
