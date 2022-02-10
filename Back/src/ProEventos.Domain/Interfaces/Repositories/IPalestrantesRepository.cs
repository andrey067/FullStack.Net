using System.Threading.Tasks;
using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Repositories
{
    public interface IPalestrantesRepository : IRepository<Palestrante>
    {
        Task<Palestrante[]> GetAllPalestrantesByNameAsync(string palestrante, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(string palestrante, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesByIdAsync(string palestrante, bool includeEventos);
    }
}