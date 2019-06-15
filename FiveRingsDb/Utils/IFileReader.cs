using System.Collections.Generic;
using FiveRingsDb.Models;

namespace FiveRingsDb.Utils
{
    public interface IFileReader
    {
        List<Card> GetCardsFromJson();
    }
}