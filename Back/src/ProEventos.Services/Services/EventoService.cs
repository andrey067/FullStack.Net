using System;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces;
using ProEventos.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Services
{
    public class EventoService : IEventoService
    {
        private readonly IRepository<Evento> _repository;
        private readonly IEventoRepository _eventoRepository;

        public EventoService(IRepository<Evento> repository, IEventoRepository eventoRepository = null)
        {
            _repository = repository;
            _eventoRepository = eventoRepository;
        }

        public async Task<Evento> AddEvento(Evento model)
        {
            try
            {
                _eventoRepository.Add(model);
                if (await _repository.SaveChangesAsync())
                    return await _eventoRepository.GetAllEventosByIdAsync(model.Id, false);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar Evento:" + ex.Message);
            }
        }

        public async Task<bool> DeleteEvento(int eventoId)
        {
            try
            {
                var evento = await _eventoRepository.GetAllEventosByIdAsync(eventoId, false);
                if (evento == null) throw new Exception("Evento não foi encontrado");

                return await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar: " + ex.Message);
            }
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

        public async Task<Evento> UpdateEvento(int eventoId, Evento model)
        {
            try
            {
                var evento = await _eventoRepository.GetAllEventosByIdAsync(eventoId, false);
                if (evento == null) return null;
                _eventoRepository.Update(model);

                model.Id = evento.Id;

                if (await _repository.SaveChangesAsync())
                    return await _eventoRepository.GetAllEventosByIdAsync(model.Id, false);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar: " + ex.Message);
            }
        }

        public async Task<List<Evento>> GetAllEventosAsync(bool includePalestrante = false)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosAsync(includePalestrante);
                if (eventos == null) return null;
                return eventos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar:" + ex.Message);
            }
        }

        public async Task<Evento> GetAllEventosByIdAsync(int eventoId, bool includePalestrante)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosByIdAsync(eventoId, includePalestrante);
                if (eventos == null) return null;
                return eventos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar:" + ex.Message);
            }
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosByTemaAsync(tema, includePalestrante);
                if (eventos == null) return null;
                return eventos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar:" + ex.Message);
            }
        }
    }
}