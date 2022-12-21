using System.Text;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.Interfaces;
using ProEventos.Services;
using ProEventos.Services.Interfaces;
using ProEventos.Services.Services;

namespace DependencyValidations.Tests
{
    public class DependencyValidation : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public DependencyValidation(WebApplicationFactory<Program> factory) => _factory = factory;

        private readonly List<(Type? ServiceType, Type? ImplType, ServiceLifetime LifeTime)> _descriptor = new()
        {
            (typeof(IEventoService), typeof(EventoService), ServiceLifetime.Scoped),
            (typeof(ILotesService), typeof(LotesServices), ServiceLifetime.Scoped)
        };

        [Fact(DisplayName = "DependencyValidation")]
        [Trait("ValidationServices", "ProEventos")]
        public void BuildServices()
        {
            var app = _factory.WithWebHostBuilder(builder => builder.ConfigureTestServices(serviceCollection =>
            {
                var services = serviceCollection.ToList();
                var result = ValidateServices(services);

                if (!result.Success)
                    Assert.True(false, result.Message);

            }));
            app.CreateClient();
        }

        private DependencyAssertionResult ValidateServices(List<ServiceDescriptor>? services)
        {
            var searchFailed = false;
            var failedText = new StringBuilder();
            foreach (var descriptor in _descriptor)
            {
                var match = services?.SingleOrDefault(x => x.ServiceType == descriptor.ServiceType
                                                      && x.ImplementationType == descriptor.ImplType
                                                      && x.Lifetime == descriptor.LifeTime);
                if (match is not null)
                    continue;

                if (!searchFailed)
                {
                    failedText.AppendLine("Failed to find registered service for");
                    searchFailed = true;
                }
                failedText.AppendLine($"{descriptor.ServiceType?.Name} - {descriptor.ImplType?.Name} - {descriptor.ImplType.Name}");

            }

            return new DependencyAssertionResult
            {
                Success = !searchFailed,
                Message = failedText.ToString()
            };
        }
    }
}
