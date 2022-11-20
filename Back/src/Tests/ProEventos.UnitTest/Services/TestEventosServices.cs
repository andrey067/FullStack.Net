using FluentAssertions;
using Helpers.Eventos;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos.Eventos;
using Xunit;

namespace ProEventos.UnitTest.Services
{
    public class TestEventosServices
    {
        private IEventoService? _service;

        [Fact(DisplayName = "GetAllEventosAsync")]
        [Trait("GET", "Eventos")]
        public async Task GetAllEventosAsync_Returns_ListEvents()
        {
            //Arrange
            var mockEventosService = IEventoServiceMock.SetupGetAllEventosAsync_ListEvents();
            _service = mockEventosService.Object;

            //Act
            var result = await _service.GetAllEventosAsync(true);

            //Assert
            result.Should().BeOfType<List<EventoDto>>();
            result.Capacity.Should().BeGreaterThan(1);
        }

        [Fact(DisplayName = "GetByIdEventosAsync")]
        [Trait("GET", "Eventos")]
        public async Task GetByIdEventosAsync_Returns_Event()
        {
            //Arrange
            var (mockEventosService, eventoDto) = IEventoServiceMock.SetupGetByIdAsync();
            _service = mockEventosService.Object;

            //Act
            var result = await _service.Get(eventoDto.Id);

            //Assert
            result.Should().BeOfType<EventoDto>();
            result.Should().Be(eventoDto);
        }

        [Fact(DisplayName = "InsertEventoAsync")]
        [Trait("POST", "Eventos")]
        public async Task InsertEventosAsync_Returns_Event()
        {
            //Arrange
            var (mockEventosService, eventoDto) = IEventoServiceMock.SetupPostEventos();
            _service = mockEventosService.Object;

            //Act
            var result = await _service.AddEvento(eventoDto);

            //Assert
            result.Should().BeOfType<EventoDto>();
            result.Should().Be(eventoDto);
        }
    }
}
