using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ProEventos.Core.Options.Database;
using ProEventos.Persistence;
using ProEventos.Persistence.Seeds;

namespace ProEventos.CrossCutting.ContextConfiguration
{
    public class DataContextConfiguration
    {
        public static void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<DataContext>((serviceProvider, dbContextOptionsBuilder) =>
            {
                var dataBaseOptions = serviceProvider.GetService<IOptions<DataBaseOptions>>()!.Value;

                dbContextOptionsBuilder.UseSqlite(dataBaseOptions.ConectionString, sqliteServerAction =>
                {
                    sqliteServerAction.CommandTimeout(dataBaseOptions.CommandTimeout);
                });

                dbContextOptionsBuilder.EnableDetailedErrors(dataBaseOptions.EnableDetailedErrors);
                dbContextOptionsBuilder.EnableSensitiveDataLogging(dataBaseOptions.EnableSensitiveDataLoggind);
            });
        }

        public static void AddSeeds(IServiceScope service)
        {
            var context = service.ServiceProvider.GetService<DataContext>();

            var isMigrationNeeded = context.Database.GetPendingMigrations().Any();

            if (isMigrationNeeded)
            {
                context.Database.Migrate();
                EventoSeeds.Eventos(context);
            }
        }
    }
}
