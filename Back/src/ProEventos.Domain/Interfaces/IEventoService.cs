using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces
{
    public interface IEventoService
    {
        Task<Evento> Get(int id);
        Task<IEnumerable<Evento>> GetAll();
        // Task<UserDtoCreateResult> Post(UserDtoCreate entity);
        // Task<UserDtoUpdateResult> Put(UserDtoUpdate entity);
        // Task<bool> Delete(Guid id);
    }
}