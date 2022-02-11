using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Persistence.Context;

namespace ProEventos.Persistence.Repository
{
    public class PalestrantesRepository : BaseRepository<Palestrante>, IPalestrantesRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<Palestrante> _palestranteContext;

        public PalestrantesRepository(DataContext context, DbSet<Palestrante> palestranteContext) : base(context)
        {
            _context = context;
            _palestranteContext = palestranteContext;
        }

        public void Add(Evento evento)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Evento evento)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync(string palestrante, bool includeEventos)
        {
            IQueryable<Palestrante> query = _palestranteContext
                                            .Include(e => e.RedeSociais);

            if (includeEventos)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Evento);
            }

            query = query.OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetAllPalestrantesByIdAsync(int palestranteId, bool includeEventos)
        {
            IQueryable<Palestrante> query = _palestranteContext
                                            .Include(e => e.RedeSociais);

            if (includeEventos)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Evento);
            }

            query = query.OrderBy(e => e.Id).Where(p => p.Id == palestranteId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNameAsync(string palestrante, bool includeEventos)
        {
            IQueryable<Palestrante> query = _palestranteContext
                                            .Include(p => p.RedeSociais);

            if (includeEventos)
            {
                query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Evento);
            }

            query = query.OrderBy(e => e.Id).Where(p => p.Nome.ToLower().Contains(palestrante.ToLower()));

            return await query.ToArrayAsync();
        }

        public void Update(Evento evento)
        {
            throw new System.NotImplementedException();
        }
    }
}