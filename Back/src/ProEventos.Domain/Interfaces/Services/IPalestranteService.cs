using System.Threading.Tasks;
using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Services
{
    public interface IPalestranteService
    {
        void Add(Palestrante evento);
        void Update(Palestrante evento);
        void Delete(Palestrante evento);
        Task<Palestrante[]> GetAllPalestrantesByNameAsync(string palestrante, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(string palestrante, bool includeEventos);
        Task<Palestrante> GetAllPalestrantesByIdAsync(int palestranteId, bool includeEventos);
    }
}