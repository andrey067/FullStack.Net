using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProEventos.Api.Filters;
using ProEventos.CrossCutting.DependencyInjection;
using ProEventos.Persistence;
using ProEventos.Persistence.Seeds;

var builder = WebApplication.CreateBuilder(args);

ConfigureRepository.ConfigureDependenciesRepository(builder.Services, builder.Configuration);
ConfigureService.ConfigureDependenciesServices(builder.Services);
ConfigureService.RegisterAutoMapper(builder.Services);
ConfigureService.SwaggerConfiguration(builder.Services);
ConfigureService.NotificationConfiguration(builder.Services);

builder.Services.AddCors();
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ResponseFilter>();
    options.Filters.Add<NotificationFilter>();
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json",
                                                        "ProEventos.Api v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(acess => acess.AllowAnyHeader()
                                       .AllowAnyMethod()
                                       .AllowAnyOrigin());

app.MapControllers();


using (var service = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    using (var context = service.ServiceProvider.GetService<DataContext>())
    {
        var isMigrationNeeded = context.Database.GetPendingMigrations().Any();
        if (isMigrationNeeded)
            EventoSeeds.Eventos(context);
    }
}

app.Run();
