using ProEventos.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Domain.Interfaces.Repositories
{
    public interface IEventoRepository : IRepository<Evento>
    {
        void Add(Evento evento);
        void Update(Evento evento);
        void Delete(Evento evento);        
        //Evento
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante);
        Task<List<Evento>> GetAllEventosAsync(bool includePalestrante);
        Task<Evento> GetAllEventosByIdAsync(int eventoId, bool includePalestrante);        
    }
}
