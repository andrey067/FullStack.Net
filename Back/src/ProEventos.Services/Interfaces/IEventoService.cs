using ProEventos.Domain.Entities;
using ProEventos.Services.Dtos.Eventos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Interfaces
{
    public interface IEventoService
    {
        Task<EventoDto> Get(int id);
        Task<IEnumerable<EventoDto>> GetAll();
        Task<EventoDto> AddEvento(CreateEventoDto model);
        Task<EventoDto> UpdateEvento(int eventoId, EventoDto model);
        Task<bool> DeleteEvento(int eventoId);
        Task<List<EventoDto>> GetAllEventosByTemaAsync(string tema, bool includePalestrante);
        Task<List<EventoDto>> GetAllEventosAsync(bool includePalestrante = false);
        Task<List<EventoDto>> GetAllEventosByIdAsync(int eventoId, bool includePalestrante);
    }
}
