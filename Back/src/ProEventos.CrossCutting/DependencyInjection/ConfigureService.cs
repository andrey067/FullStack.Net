using ProEventos.Services;
using ProEventos.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ProEventos.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEventoService, EventoService>();
        }
    }
}