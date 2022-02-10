using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.Domain.Interfaces;
using ProEventos.Persistence;
using ProEventos.Persistence.Repository;

namespace ProEventos.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddDbContext<DataContext>(options => options.UseSqlite(configuration.GetConnectionString("Default")));
        }
    }
}