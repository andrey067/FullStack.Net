using FluentAssertions;
using Helpers.Eventos;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos;
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
    }
}
