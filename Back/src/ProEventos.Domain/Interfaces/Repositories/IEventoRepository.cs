using ProEventos.Domain.Entities;
using System.Threading.Tasks;

namespace ProEventos.Domain.Interfaces.Repositories
{
    public interface IEventoRepository : IRepository<Evento>
    {
        //Evento
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante);
        Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrante);
        Task<Evento[]> GetAllEventosByIdAsync(string tema, bool includePalestrante);

        //Palestrante
        Task<Palestrante[]> GetAllPalestrantesByNameAsync(string palestrante, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(string palestrante, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesByIdAsync(string palestrante, bool includeEventos);
    }
}
