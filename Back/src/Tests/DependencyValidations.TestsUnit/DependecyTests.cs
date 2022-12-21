using System.Text;
using DependencyValidations.Tests;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.Interfaces;
using ProEventos.Services;
using ProEventos.Services.Interfaces;
using ProEventos.Services.Services;

namespace DependencyValidations.TestsUnit
{
    public class DependecyTests
    {
        private readonly List<(Type? ServiceType, Type? ImplType, ServiceLifetime LifeTime)> _descriptor = new()
        {
            (typeof(IEventoService), typeof(EventoService), ServiceLifetime.Scoped),
            (typeof(ILotesService), typeof(LotesServices), ServiceLifetime.Scoped)
        };

        [TestCase]
        public void RegistrationValidation()
        {
            //var app = new WebApplicationFactory<IApiMaker>().WithWebHostBuilder(builder => builder.ConfigureTestServices(serviceCollection =>
            //{
            //    var services = serviceCollection.ToList();
            //    var result = ValidateServices(services);

            //    if (!result.Success)
            //        Assert.Fail(result.Message);

            //    Assert.Pass();
            //}));

            //app.CreateClient();
        }

        private DependencyAssertionResult ValidateServices(List<ServiceDescriptor>? services)
        {
            var searchFailed = false;
            var failedText = new StringBuilder();
            foreach (var descriptor in _descriptor)
            {
                var match = services.SingleOrDefault(x => x.ServiceType == descriptor.ServiceType &&
                                                          x.Lifetime == descriptor.LifeTime &&
                                                          x.ImplementationType == descriptor.ImplType);
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
