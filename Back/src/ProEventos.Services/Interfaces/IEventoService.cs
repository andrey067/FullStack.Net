using ProEventos.Domain.Entities;
using ProEventos.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Interfaces
{
    public interface IEventoService
    {
        Task<EventoDto> Get(int id);
        Task<IEnumerable<EventoDto>> GetAll();
        Task<EventoDto> AddEvento(EventoDto model);
        Task<EventoDto> UpdateEvento(int eventoId, EventoDto model);
        Task<bool> DeleteEvento(int eventoId);
        Task<List<EventoDto>> GetAllEventosByTemaAsync(string tema, bool includePalestrante);
        Task<List<EventoDto>> GetAllEventosAsync(bool includePalestrante = false);
        Task<EventoDto> GetAllEventosByIdAsync(int eventoId, bool includePalestrante);
    }
}
