using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.Domain.Entities;
using ProEventos.Interfaces;
using ProEventos.Services;
using ProEventos.Services.Dtos;

namespace ProEventos.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEventoService, EventoService>();
        }

        public static void RegisterAutoMapper(IServiceCollection services)
        {
            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Evento, EventoDto>().ReverseMap();
                cfg.CreateMap<Lote, LoteDto>().ReverseMap();
                cfg.CreateMap<Palestrante, PalestranteDto>().ReverseMap();
                cfg.CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
            });
            services.AddSingleton(autoMapperConfig.CreateMapper());
        }
    }
}