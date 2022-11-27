using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProEventos.Api.Filters;
using ProEventos.Core.Options.Database;
using ProEventos.CrossCutting.ContextConfiguration;
using ProEventos.CrossCutting.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

ConfigureRepository.Configure(builder.Services);
DataContextConfiguration.Configure(builder.Services);
ConfigureService.ConfigureDependenciesServices(builder.Services);
ConfigureService.RegisterAutoMapper(builder.Services);
ConfigureService.SwaggerConfiguration(builder.Services);
ConfigureService.NotificationConfiguration(builder.Services);

builder.Services.ConfigureOptions<DataBaseOptionsSetup>();
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

DataContextConfiguration.AddSeeds(app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope());

app.Run();
