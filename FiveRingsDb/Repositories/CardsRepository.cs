using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using FiveRingsDb.Models;
using FiveRingsDb.Utils.JsonConverter;
using Microsoft.EntityFrameworkCore;

namespace FiveRingsDb.Repositories
{
    public class CardsRepository : ICardsRepository
    {
        private const string JsonDataPath = "../fiveringsdb-data/json/Card";
        private readonly FiveRingsDbContext db;

        public CardsRepository(FiveRingsDbContext fiveRingsDbContext)
        {
            db = fiveRingsDbContext;
        }

        public async Task<IEnumerable<Card>> GetCards()
        {
            return await db.Cards.ToListAsync();
        }

        public async Task<Card> GetCard(string id)
        {
            return await db.Cards.FindAsync(id);
        }

        public void AddCards(IEnumerable<Card> cards)
        {
            db.Cards.AddRange(cards);
            db.SaveChanges();
        }

        public void UpdateCardDatabase()
        {
            var converter = new JsonConverter();
            var cards = new List<Card>();
            var directoryInfo = new DirectoryInfo(JsonDataPath);
            var files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                var streamReader = file.OpenText();
                var json = streamReader.ReadToEnd();
                var card = converter.ConvertToCard(json);
                cards.Add(card);
            }

            AddCards(cards);
        }
    }
}
