using System.Collections.Generic;
using System.Threading.Tasks;
using FiveRingsDb.Models;
using Microsoft.EntityFrameworkCore;

namespace FiveRingsDb.Repositories
{
    public class CardsRepository : ICardsRepository
    {
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
    }
}
