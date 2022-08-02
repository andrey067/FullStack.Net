using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Repository
{
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {        
        private readonly DbSet<Evento> _eventoContext;
        public EventoRepository(DataContext context) : base(context) => _eventoContext = context.Set<Evento>();

        public async Task<List<Evento>> GetAllEventosAsync(bool includePalestrante = false)
        {
            IQueryable<Evento> query = _eventoContext
                                    .Include(e => e.Lotes)
                                    .Include(e => e.RedeSociais);

            if (includePalestrante)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            return await query.ToListAsync();
        }

        public async Task<Evento> GetAllEventosByIdAsync(int EventoId, bool includePalestrante)
        {
            IQueryable<Evento> query = _eventoContext
                                    .Include(e => e.Lotes)
                                    .Include(e => e.RedeSociais);

            if (includePalestrante)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            query = query.OrderBy(e => e.Id)
                         .Where(ev => ev.Id == EventoId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<Evento>> GetAllEventosByTemaAsync(string tema, bool includePalestrante)
        {
            IQueryable<Evento> query = _eventoContext
                                    .Include(e => e.Lotes)
                                    .Include(e => e.RedeSociais);

            if (includePalestrante)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            query = query.OrderBy(e => e.Id)
                         .Where(ev => ev.Tema.ToLower().Contains(tema.ToLower()));

            return await query.ToListAsync();
        }        
    }
}
