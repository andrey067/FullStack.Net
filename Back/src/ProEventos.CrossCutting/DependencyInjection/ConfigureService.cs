using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using ProEventos.Core.Notifications.Implementation;
using ProEventos.Core.Notifications.Interfaces;
using ProEventos.CrossCutting.MappinsConfiguration.Evento;
using ProEventos.Domain.Entities;
using ProEventos.Interfaces;
using ProEventos.Services;
using ProEventos.Services.Dtos;
using ProEventos.Services.Interfaces;
using ProEventos.Services.Services;

namespace ProEventos.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesServices(IServiceCollection services)
        {
            services.AddTransient<IEventoService, EventoService>();
            services.AddTransient<ILotesService, LotesServices>();
        }

        public static void RegisterAutoMapper(IServiceCollection services)
        {
            var autoMapperConfig = new MapperConfiguration(configuration =>
            {
                EventoMappringConfiguration.EventoMapping(configuration);
                configuration.CreateMap<Lote, LoteDto>().ReverseMap();
                configuration.CreateMap<Palestrante, PalestranteDto>().ReverseMap();
                configuration.CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
            });

            services.AddSingleton(autoMapperConfig.CreateMapper());
        }

        public static void SwaggerConfiguration(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ProEventos.Api",
                    Version = "v1"
                });
            });
        }


        public static void NotificationConfiguration(IServiceCollection services)
        {
            services.AddScoped<INotifications, Notifications>();
        }
    }
}
