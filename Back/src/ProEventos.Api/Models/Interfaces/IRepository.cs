using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Api.Models.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(int id);
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectAsyncAll();
        Task<bool> ExistAsync(int id);
    }
}