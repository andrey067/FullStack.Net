using System.Threading.Tasks;
using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Repositories
{
    public interface IPalestrantesRepository : IRepository<Palestrante>
    {
        void Add(Evento evento);
        void Update(Evento evento);
        void Delete(Evento evento);  
        Task<Palestrante[]> GetAllPalestrantesByNameAsync(string palestrante, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(string palestrante, bool includeEventos);
        Task<Palestrante> GetAllPalestrantesByIdAsync(int palestranteId, bool includeEventos);
    }
}