using ProEventos.Domain.Entities;
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
        Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrante);
        Task<Evento> GetAllEventosByIdAsync(int eventoId, bool includePalestrante);        
    }
}
