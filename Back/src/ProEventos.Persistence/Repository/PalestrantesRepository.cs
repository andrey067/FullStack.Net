using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;

namespace ProEventos.Persistence.Repository
{
    
    public class PalestrantesRepository : IPalestrantesRepository
    {
        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRange(Palestrante[] entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new System.NotImplementedException();
        }

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

        public Task<Palestrante> InsertAsync(Palestrante item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante> SelectAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Palestrante>> SelectAsyncAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante> UpdateAsync(Palestrante item)
        {
            throw new System.NotImplementedException();
        }
    }
}