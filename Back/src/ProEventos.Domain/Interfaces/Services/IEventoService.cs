using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces
{
    public interface IEventoService
    {
        Task<Evento> Get(int id);
        Task<IEnumerable<Evento>> GetAll();
        Task<Evento> AddEvento(Evento model);
        Task<Evento> UpdateEvento(int eventoId, Evento model);
        Task<bool> DeleteEvento(int eventoId);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante);
        Task<List<Evento>> GetAllEventosAsync(bool includePalestrante = false);
        Task<Evento> GetAllEventosByIdAsync(int eventoId, bool includePalestrante);
    }
}
