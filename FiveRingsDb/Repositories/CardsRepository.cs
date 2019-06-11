﻿using System.Collections.Generic;
using System.Threading.Tasks;
using FiveRingsDb.Models;
using FiveRingsDb.Utils;
using Microsoft.EntityFrameworkCore;

namespace FiveRingsDb.Repositories
{
    public class CardsRepository : ICardsRepository
    {
        private readonly FiveRingsDbContext db;
        private readonly IFileReader fileReader;

        public CardsRepository(FiveRingsDbContext fiveRingsDbContext, IFileReader fileReader)
        {
            db = fiveRingsDbContext;
            this.fileReader = fileReader;
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
            var cards = fileReader.GetCardsFromJson();

            AddCards(cards);
        }
    }
}
