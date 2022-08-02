using ProEventos.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Services.Interfaces
{
    public interface ILotesService
    {
        Task AddLote(int eventoId, LoteDto model);
        Task<List<LoteDto>> SaveLotes(int eventoId, List<LoteDto> models);
        Task<bool> DeleteLote(int eventoId, int loteId);

        Task<List<LoteDto>> GetLotesByEventoIdAsync(int eventoId);
        Task<LoteDto> GetLoteByIdsAsync(int eventoId, int loteId);
    }
}
