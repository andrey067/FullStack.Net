using FluentAssertions;
using Helpers.Eventos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Controllers;
using Xunit;

namespace ProEventos.UnitTest.Controllers.Eventos
{
    public class TestsEventosController_Delete
    {
        [Fact(DisplayName = "Delete OnSuccess ResturnsCode200")]
        [Trait("DELETE", "Eventos")]
        public async Task Delete_OnSuccess_ResturnsCode200()
        {
            //Arrange
            var (mockEventosService, eventoId) = IEventoServiceMock.SetupDeleteEvento(true);
            var sut = new EventosController();

            //Act
            var result = await sut.DeletarEvento(mockEventosService.Object, eventoId);

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult)result!;
            objectResult.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact(DisplayName = "Delete ResturnsCode204")]
        [Trait("DELETE", "Eventos")]
        public async Task Delete_ResturnsCode204()
        {
            //Arrange
            var (mockEventosService, eventoId) = IEventoServiceMock.SetupDeleteEvento(false);
            var sut = new EventosController();

            //Act
            var result = await sut.DeletarEvento(mockEventosService.Object, eventoId);

            //Assert
            result.Should().BeOfType<NoContentResult>();
            var objectResult = (NoContentResult)result!;
            objectResult.StatusCode.Should().Be(StatusCodes.Status204NoContent);
        }
    }
}
