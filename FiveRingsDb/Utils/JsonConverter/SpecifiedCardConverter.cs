using FiveRingsDb.Models;
using Newtonsoft.Json.Serialization;
using Type = System.Type;

namespace FiveRingsDb.Utils.JsonConverter
{
    internal class SpecifiedCardConverter : DefaultContractResolver
    {
        protected override Newtonsoft.Json.JsonConverter ResolveContractConverter(Type objectType)
        {
            if (typeof(Card).IsAssignableFrom(objectType) && !objectType.IsAbstract)
            {
                return null;
            }

            return base.ResolveContractConverter(objectType);
        }
    }
}