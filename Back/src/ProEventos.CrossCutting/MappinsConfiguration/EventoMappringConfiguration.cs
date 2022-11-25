using AutoMapper;
using ProEventos.Domain.Entities;
using ProEventos.Services.Dtos.Eventos;

namespace ProEventos.CrossCutting.MappinsConfiguration
{
    public class EventoMappringConfiguration
    {
        public static void EventoMapping(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CreateEventoDto, EventoDto>();
            configuration.CreateMap<UpdateEventoDto, EventoDto>();
            configuration.CreateMap<Evento, EventoDto>().ReverseMap();
        }
    }
}
