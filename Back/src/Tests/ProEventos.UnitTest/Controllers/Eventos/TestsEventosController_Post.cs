using FluentAssertions;
using Helpers.Eventos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ProEventos.Api.Controllers;
using ProEventos.Services.Dtos.Eventos;
using Xunit;

namespace ProEventos.UnitTest.Eventos.Controllers
{
    public class TestsEventosController_Post
    {
        [Fact(DisplayName = "PostEventos OnSuccess ResturnsCode200")]
        [Trait("Post", "Eventos")]
        public async Task Post_OnSuccess_ResturnsCode200()
        {
            //Arrange
            var (mockEventosService, createEventoDto, fakeDto) = IEventoServiceMock.SetupPostEvento();
            var sut = new EventosController();

            //Act
            var result = await sut.InsertEvento(mockEventosService.Object, createEventoDto);

            //Assert
            result.Result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult)result.Result!;
            objectResult.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact(DisplayName = "PostEventos OnSuccess InvokesUserServiceExactlyOnce")]
        [Trait("Post", "Eventos")]
        public async Task Post_OnSuccess_InvokesUserServiceExactlyOnce()
        {
            //Arrange
            var (mockEventosService, createEventoDto, fakeDto) = IEventoServiceMock.SetupPostEvento();
            var sut = new EventosController();

            //Act
            var result = await sut.InsertEvento(mockEventosService.Object, createEventoDto);

            //Assert
            mockEventosService.Verify(service => service.AddEvento(createEventoDto), Times.Once());
        }

        [Fact(DisplayName = "Post OnSuccess ReturnEvent")]
        [Trait("Post", "Eventos")]
        public async Task Post_OnSuccess_ReturnsListOfEvents()
        {
            //Arrange
            var (mockEventosService, createEventoDto, fakeEventoDto) = IEventoServiceMock.SetupPostEvento();
            var sut = new EventosController();

            //Act
            var result = await sut.InsertEvento(mockEventosService.Object, createEventoDto);

            //Assert
            result.Result.Should().BeOfType<OkObjectResult>();
            var objectResulto = (OkObjectResult)result.Result!;
            fakeEventoDto.Tema.Should().Be(fakeEventoDto.Tema);
            objectResulto.Value.Should().BeOfType<EventoDto>();
        }
    }
}
