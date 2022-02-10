using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(int id);
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectAsyncAll();
        Task<bool> ExistAsync(int id);
        void DeleteRange(T[] entity);
        Task<bool> SaveChangesAsync();
    }
}