using System.Collections.Generic;
using System.Threading.Tasks;
using FiveRingsDb.Models;

namespace FiveRingsDb.Repositories
{
    public interface ICardsRepository
    {
        Task<IEnumerable<Card>> GetCards();

        Task<Card> GetCard(string id);
    }
}
