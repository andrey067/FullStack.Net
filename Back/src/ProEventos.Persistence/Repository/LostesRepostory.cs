using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Repository
{
    public class LostesRepostory : BaseRepository<Lote>, ILotesRepository
    {
        private readonly DbSet<Lote> _eventoContext;
        public LostesRepostory(DataContext context) : base(context) => _eventoContext = context.Set<Lote>();

        public async Task<Lote> GetLoteByIdsAsync(int eventoId, int id) =>
                                             await _eventoContext.AsNoTracking()
                                            .Where(lote => lote.Evento.Id == eventoId && lote.Id == id)
                                            .FirstOrDefaultAsync();


        public async Task<List<Lote>> GetLotesByEventoIdAsync(int eventoId) => await _eventoContext.AsNoTracking()
                         .Where(lote => lote.Evento.Id == eventoId).ToListAsync();
    }
}
