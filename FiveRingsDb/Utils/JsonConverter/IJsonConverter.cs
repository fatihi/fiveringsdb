using FiveRingsDb.Models;

namespace FiveRingsDb.Utils.JsonConverter
{
    public interface IJsonConverter
    {
        Card ConvertToCard(string json);
    }
}