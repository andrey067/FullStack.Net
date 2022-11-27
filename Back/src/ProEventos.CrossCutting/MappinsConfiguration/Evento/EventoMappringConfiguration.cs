using AutoMapper;
using EventoEntity = ProEventos.Domain.Entities.Evento;
using ProEventos.Services.Dtos.Eventos;

namespace ProEventos.CrossCutting.MappinsConfiguration.Evento
{
    public class EventoMappringConfiguration
    {
        public static void EventoMapping(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CreateEventoDto, EventoDto>();
            configuration.CreateMap<UpdateEventoDto, EventoDto>();
            configuration.CreateMap<EventoEntity, EventoDto>().ReverseMap();
        }
    }
}
