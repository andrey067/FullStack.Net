using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces
{
    public interface IEventoService
    {
        void Add(Evento evento);
        void Update(Evento evento);
        void Delete(Evento evento);        
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante);
        Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrante);
        Task<Evento> GetAllEventosByIdAsync(int eventoId, bool includePalestrante);
    }
}