using FiveRingsDb.Models;
using Newtonsoft.Json;

namespace FiveRingsDb.Utils.JsonConverter
{
    public class JsonConverter : IJsonConverter
    {
        public Card ConvertToCard(string json)
        {
            return JsonConvert.DeserializeObject<Card>(json);
        }
    }
}
