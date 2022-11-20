using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ProEventos.Core.Notifications.Interfaces;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos;

namespace ProEventos.Services
{
    public class EventoService : IEventoService
    {
        private readonly IRepository<Evento> _repository;
        private readonly IEventoRepository _eventoRepository;
        private readonly IMapper _mapper;
        private readonly INotifications _notifications;

        public EventoService(IRepository<Evento> repository, IEventoRepository eventoRepository, IMapper mapper, INotifications notifications)
        {
            _repository = repository;
            _eventoRepository = eventoRepository;
            _mapper = mapper;
            _notifications = notifications;
        }

        public async Task<EventoDto> AddEvento(EventoDto model)
        {
            var entity = _mapper.Map<Evento>(model);
            if (entity.Invalid)
            {
                _notifications.AddNotification(entity.Errors);
                return null;
            }

            var eventoSalvo = await _repository.InsertAsync(entity);
            if (await _repository.SaveChangesAsync())
                return _mapper.Map<EventoDto>(await _eventoRepository.GetAllEventosByIdAsync(eventoSalvo.Id, false));
            return null;
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

        public async Task<EventoDto> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            if (entity != null)
                return _mapper.Map<EventoDto>(entity);
            //TODO - Tratar Erro
            return null;
        }

        public async Task<IEnumerable<EventoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsyncAll();
            var listEventoDto = _mapper.Map<IEnumerable<EventoDto>>(listEntity);
            return listEventoDto;
        }

        public async Task<EventoDto> UpdateEvento(int eventoId, EventoDto model)
        {
            try
            {
                var evento = await _eventoRepository.GetAllEventosByIdAsync(eventoId, false);
                if (evento == null) return null;
                var eventoSalvo = await _repository.UpdateAsync(_mapper.Map<Evento>(model));


                if (await _repository.SaveChangesAsync())
                    return _mapper.Map<EventoDto>(await _eventoRepository.GetAllEventosByIdAsync(eventoSalvo.Id, false));
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar: " + ex.Message);
            }
        }

        public async Task<List<EventoDto>> GetAllEventosAsync(bool includePalestrante = false)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosAsync(includePalestrante);
                if (eventos == null) return null;

                var eventoRetorno = _mapper.Map<List<EventoDto>>(eventos);

                return eventoRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar:" + ex.Message);
            }
        }

        public async Task<List<EventoDto>> GetAllEventosByIdAsync(int eventoId, bool includePalestrante)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosByIdAsync(eventoId, includePalestrante);
                if (eventos == null) return null;
                var eventoDto = _mapper.Map<List<EventoDto>>(eventos);
                return eventoDto;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar:" + ex.Message);
            }
        }

        public async Task<List<EventoDto>> GetAllEventosByTemaAsync(string tema, bool includePalestrante)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosByTemaAsync(tema, includePalestrante);
                if (eventos == null) return null;
                var eventoDto = _mapper.Map<List<EventoDto>>(eventos);
                return eventoDto;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar:" + ex.Message);
            }
        }
    }
}
