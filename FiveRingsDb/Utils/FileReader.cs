using System.Collections.Generic;
using System.IO;
using System.Linq;
using FiveRingsDb.Models;
using Newtonsoft.Json;

namespace FiveRingsDb.Utils
{
    public class FileReader : IFileReader
    {
        private const string DATA_BASE_PATH = "../fiveringsdb-data/json";
        private const string CARD_PATH = "/Card";
        private const string TRANSLATION_PATH = "/Translation";

        public List<Card> GetCardsFromJson()
        {
            var converter = new JsonConverter.JsonConverter();
            var cards = new List<Card>();
            var directoryInfo = new DirectoryInfo(DATA_BASE_PATH + CARD_PATH);
            var files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                using var streamReader = file.OpenText();
                var json = streamReader.ReadToEnd();
                var card = converter.Convert<Card>(json);
                cards.Add(card);
            }

            return cards;
        }

        public List<PackTranslation> GetTranslationsForLanguage(string language)
        {
            var translations = new List<PackTranslation>();
            var directoryInfo = new DirectoryInfo(DATA_BASE_PATH + TRANSLATION_PATH);
            var directories = directoryInfo.GetDirectories();
            var files = directories.Select(x => x.GetFiles().FirstOrDefault(y => y.Name == language + ".json"));

            foreach (var file in files)
            {
                using var streamReader = file.OpenText();
                var json = streamReader.ReadToEnd();
                var packTranslation = JsonConvert.DeserializeObject<PackTranslation>(json);
                translations.Add(packTranslation);
            }

            return translations;
        }
    }

    public class PackTranslation
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<CardTranslation> CardTranslations { get; set; }
    }

    public class CardTranslation
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public string Flavor { get; set; }
    }
}
