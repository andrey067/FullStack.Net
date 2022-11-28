using FluentAssertions;
using Helpers.Eventos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Controllers;
using Xunit;

namespace ProEventos.UnitTest.Controllers.Eventos
{
    public class TestsEventosController_Put
    {
        [Fact(DisplayName = "PutEventosAsync OnSuccess ResturnsCode200")]
        [Trait("Put", "Eventos")]
        public async Task Put_OnSuccess_ResturnsCode200()
        {
            //Arrange
            var (mockEventosService, updatedEvento, eventoDto) = IEventoServiceMock.SetupPutEvento();
            var sut = new EventosController();

            //Act
            var result = await sut.UpdateEvento(mockEventosService.Object, updatedEvento);

            //Assert
            result.Result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult)result.Result!;
            objectResult.StatusCode.Should().Be(StatusCodes.Status200OK);
        }
    }
}
