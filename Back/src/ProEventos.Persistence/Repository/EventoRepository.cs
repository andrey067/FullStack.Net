using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Repository
{
    public class EventoRepository : IEventoRepository
    {
        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange<T>(T[] entity) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrante)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByIdAsync(string tema, bool includePalestrante)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(string palestrante, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByIdAsync(string palestrante, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNameAsync(string palestrante, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Evento> InsertAsync(Evento item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Evento> SelectAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Evento>> SelectAsyncAll()
        {
            throw new NotImplementedException();
        }

        public Task<Evento> UpdateAsync(Evento item)
        {
            throw new NotImplementedException();
        }
    }
}
