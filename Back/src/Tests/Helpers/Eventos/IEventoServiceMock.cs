using Moq;
using ProEventos.Fixtures.Eventos;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos.Eventos;

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

        public static (Mock<IEventoService>, CreateEventoDto, EventoDto) SetupPostEvento()
        {
            var mockEventosService = new Mock<IEventoService>();
            var (createteEventoDto, eventoDto) = EventosFixture.PostEvento();

            mockEventosService.Setup(service => service.AddEvento(createteEventoDto)).ReturnsAsync(eventoDto);
            return (mockEventosService, createteEventoDto, eventoDto);
        }

        public static (Mock<IEventoService>, int) SetupDeleteEvento(bool deleteStatus)
        {
            var mockEventosService = new Mock<IEventoService>();
            var eventoId = EventosFixture.DeleteEvento();

            mockEventosService.Setup(service => service.DeleteEvento(eventoId)).ReturnsAsync(deleteStatus);

            return (mockEventosService, eventoId);
        }

        public static (Mock<IEventoService>, UpdateEventoDto, EventoDto) SetupPutEvento()
        {
            var mockEventosService = new Mock<IEventoService>();
            var (updatedEvento, eventodto) = EventosFixture.PutEvento();

            mockEventosService.Setup(service => service.UpdateEvento(updatedEvento)).ReturnsAsync(eventodto);

            return (mockEventosService, updatedEvento, eventodto);
        }
    }
}
