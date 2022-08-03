using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.Domain.Interfaces;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Persistence;
using ProEventos.Persistence.Repository;

namespace ProEventos.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IEventoRepository, EventoRepository>();
            serviceCollection.AddScoped<ILotesRepository, LostesRepostory>();
            serviceCollection.AddScoped<IPalestrantesRepository, PalestrantesRepository>();
            serviceCollection.AddDbContext<DataContext>(options => options.UseSqlite(configuration.GetConnectionString("Default")));
        }

        public static void AddSeeds(DataContext dataContext)
        {

        }
    }
}