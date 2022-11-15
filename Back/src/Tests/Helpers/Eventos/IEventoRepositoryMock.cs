using Moq;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Fixtures.Eventos;
using ProEventos.Interfaces;

namespace Helpers.Eventos
{
    public class IEventoRepositoryMock
    {
        public static Mock<IEventoRepository> SetupGetAllEventosAsync_ListEvents()
        {
            var mockEventosService = new Mock<IEventoRepository>();
            mockEventosService.Setup(repository => repository.GetAllEventosAsync(true)).ReturnsAsync(EventosFixture.GetEventos());
            return mockEventosService;
        }
    }
}
