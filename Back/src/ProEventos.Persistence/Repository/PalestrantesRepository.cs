using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;

namespace ProEventos.Persistence.Repository
{

    public class PalestrantesRepository : BaseRepository<Palestrante>, IPalestrantesRepository
    {
        private readonly DbSet<Palestrante> _palestranteContext;
        public PalestrantesRepository(DataContext context) : base(context)
        => _palestranteContext = context.Set<Palestrante>();

        public Task<Palestrante[]> GetAllPalestrantesAsync(string palestrante, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByIdAsync(string palestrante, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNameAsync(string palestrante, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }
    }
}
