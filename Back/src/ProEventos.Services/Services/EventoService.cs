using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces;
using ProEventos.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Services
{
    public class EventoService : IEventoService
    {]
        private readonly IEventoRepository _eventoRepository;
        private readonly IRepository<Evento> _repository;

        public EventoService(IEventoRepository eventoRepository, IRepository<Evento> repository)
        {
            _eventoRepository = eventoRepository;
            _repository = repository;
        }

        public void Add(Evento evento)
        {
            try
            {
                var result = _eventoRepository.Add<Evento>(evento)
            }
            catch (System.Exception)
            {

            }
        }

        public void Delete(Evento evento)
        {
            throw new System.NotImplementedException();
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

        public Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrante)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento> GetAllEventosByIdAsync(int eventoId, bool includePalestrante)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Evento evento)
        {
            throw new System.NotImplementedException();
        }
    }
}