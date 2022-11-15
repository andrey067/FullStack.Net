using Moq;
using ProEventos.Fixtures.Eventos;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos;

namespace Helpers.Eventos
{
    public static class IEventoServiceMock
    {
        public static Mock<IEventoService> SetupGetAllEventosAsync_ListEvents()
        {
            var mockEventosService = new Mock<IEventoService>();
            mockEventosService.Setup(service => service.GetAllEventosAsync(true)).ReturnsAsync(EventosFixture.GetEventosDto());
            return mockEventosService;
        }

        public static Mock<IEventoService> SetupGetAllEventosAsync_ListEmpty()
        {
            var mockEventosService = new Mock<IEventoService>();
            mockEventosService.Setup(services => services.GetAllEventosAsync(true)).ReturnsAsync(new List<EventoDto>());
            return mockEventosService;
        }

        public static (Mock<IEventoService>, EventoDto) SetupGetByIdAsync()
        {
            var mockEventosService = new Mock<IEventoService>();
            var eventoDtoFake = EventosFixture.GetEventoDto();
            mockEventosService.Setup(service => service.Get(eventoDtoFake.Id)).ReturnsAsync(eventoDtoFake);
            return (mockEventosService, eventoDtoFake);
        }

        public static (Mock<IEventoService>, EventoDto?) SetupGetByIdAsync_NotFound()
        {
            var mockEventosService = new Mock<IEventoService>();
            var eventoDtoFake = EventosFixture.GetEventoDto();
            mockEventosService.Setup(service => service.Get(eventoDtoFake.Id)).ReturnsAsync(() => null);
            return (mockEventosService, eventoDtoFake);
        }
    }
}
