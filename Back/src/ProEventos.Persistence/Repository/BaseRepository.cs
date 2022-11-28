using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces;

namespace ProEventos.Persistence.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dataSet;
        public BaseRepository(DataContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result == null) return false;
            _dataSet.Remove(result);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<T> InsertAsync(T item)
        {
            _dataSet.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<T> SelectAsync(int id)
        {
            return await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> SelectAsyncAll()
        {
            return await _dataSet.ToListAsync();
        }

        public async Task<T> UpdateAsync(T item)
        {

            var result = await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
            if (result == null)
                return null;

            item.UptadeEntity();

            _context.Entry(result).CurrentValues.SetValues(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataSet.AnyAsync(p => p.Id.Equals(id));
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void DeleteRange(T[] entity)
        {
            _context.RemoveRange(entity);
        }
    }
}
