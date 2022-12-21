using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProEventos.Core.Notifications;
using ProEventos.Core.Notifications.Enums;
using ProEventos.Core.Notifications.Interfaces;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos.Eventos;

namespace ProEventos.Services
{
    public class EventoService : IEventoService
    {
        private readonly IRepository<Evento> _repository;
        private readonly IEventoRepository _eventoRepository;
        private readonly IMapper _mapper;
        private readonly INotifications _notifications;
        private readonly IDomainNotificationHandlerAsync<DomainNotification> _domainNotificationHandlerAsync;

        public EventoService(IRepository<Evento> repository, IEventoRepository eventoRepository, IMapper mapper, INotifications notifications, IDomainNotificationHandlerAsync<DomainNotification> domainNotificationHandlerAsync)
        {
            _repository = repository;
            _eventoRepository = eventoRepository;
            _mapper = mapper;
            _domainNotificationHandlerAsync = domainNotificationHandlerAsync;
            //_notifications = notifications;
        }

        public async Task<EventoDto> AddEvento(CreateEventoDto eventDto)
        {
            var entity = _mapper.Map<Evento>(eventDto);
            if (entity.Invalid)
            {
                //_domainNotificationHandlerAsync.HandleAsync(entity.Errors);
                entity.Errors.ToList().ForEach(mensagem => _domainNotificationHandlerAsync.HandleAsync((new DomainNotification(TipoDeNotificacao.ErroDeServico, mensagem))));
                return null;
            }

            var eventoSalvo = await _repository.InsertAsync(entity);
            if (await _repository.SaveChangesAsync())
                return _mapper.Map<EventoDto>(await _eventoRepository.GetAllEventosByIdAsync(eventoSalvo.Id, false));
            return null;
        }

        public async Task<bool> DeleteEvento(int eventoId)
        {
            var evento = await _eventoRepository.GetAllEventosByIdAsync(eventoId, false);
            if (evento == null) return false;

            return await _repository.SaveChangesAsync();
        }

        public async Task<EventoDto> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            if (entity != null)
                return _mapper.Map<EventoDto>(entity);
            return null;
        }

        public async Task<IEnumerable<EventoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsyncAll();
            var listEventoDto = _mapper.Map<IEnumerable<EventoDto>>(listEntity);
            return listEventoDto;
        }

        public async Task<EventoDto> UpdateEvento(UpdateEventoDto model)
        {
            var evento = await _eventoRepository.SelectAsync(model.Id);
            if (evento == null) return null;

            var eventoAtualizar = _mapper.Map<Evento>(model);

            if (!eventoAtualizar.Valid)
            {
                //_notifications.AddNotification(eventoAtualizar.Errors);
                return null;
            }

            var eventoSalvo = await _repository.UpdateAsync(eventoAtualizar);

            if (await _repository.SaveChangesAsync())
                return _mapper.Map<EventoDto>(await _eventoRepository.GetAllEventosByIdAsync(eventoSalvo.Id, false));
            return null;
        }

        public async Task<List<EventoDto>> GetAllEventosAsync(bool includePalestrante = false)
        {
            var eventos = await _eventoRepository.GetAllEventosAsync(includePalestrante);
            if (eventos == null) return null;

            var eventoRetorno = _mapper.Map<List<EventoDto>>(eventos);

            return eventoRetorno;
        }

        public async Task<List<EventoDto>> GetAllEventosByIdAsync(int eventoId, bool includePalestrante)
        {
            var eventos = await _eventoRepository.GetAllEventosByIdAsync(eventoId, includePalestrante);
            if (eventos == null) return null;
            var eventoDto = _mapper.Map<List<EventoDto>>(eventos);
            return eventoDto;
        }


        public async Task<List<EventoDto>> GetAllEventosByTemaAsync(string tema, bool includePalestrante)
        {
            var eventos = await _eventoRepository.GetAllEventosByTemaAsync(tema, includePalestrante);
            if (eventos == null) return null;
            var eventoDto = _mapper.Map<List<EventoDto>>(eventos);
            return eventoDto;
        }
    }
}
