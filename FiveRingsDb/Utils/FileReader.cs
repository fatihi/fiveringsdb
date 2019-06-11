using System.Collections.Generic;
using System.IO;
using FiveRingsDb.Models;

namespace FiveRingsDb.Utils
{
    public class FileReader : IFileReader
    {
        private const string JsonDataPath = "../fiveringsdb-data/json/Card";

        public List<Card> GetCardsFromJson()
        {
            var converter = new JsonConverter.JsonConverter();
            var cards = new List<Card>();
            var directoryInfo = new DirectoryInfo(JsonDataPath);
            var files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                using (var streamReader = file.OpenText())
                {
                    var json = streamReader.ReadToEnd();
                    var card = converter.ConvertToCard(json);
                    cards.Add(card);
                }
            }

            return cards;
        }
    }
}
