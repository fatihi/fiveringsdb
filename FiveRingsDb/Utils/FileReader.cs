using System.Collections.Generic;
using System.IO;
using FiveRingsDb.Models;

namespace FiveRingsDb.Utils
{
    public class FileReader : IFileReader
    {
        private const string JSON_DATA_PATH = "../fiveringsdb-data/json/Card";

        public List<Card> GetCardsFromJson()
        {
            var converter = new JsonConverter.JsonConverter();
            var cards = new List<Card>();
            var directoryInfo = new DirectoryInfo(JSON_DATA_PATH);
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
