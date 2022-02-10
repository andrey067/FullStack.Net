using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Services
{
    public class EventoService : IEventoService
    {
        private readonly IRepository<Evento> _repository;

        public EventoService(IRepository<Evento> repository)
        {
            _repository = repository;
        }

        public async Task<Evento> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return entity;
        }

        public async Task<IEnumerable<Evento>> GetAll()
        {
            var listEntity = await _repository.SelectAsyncAll();
            return listEntity;
        }
    }
}