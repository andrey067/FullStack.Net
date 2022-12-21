using FluentAssertions;
using Helpers.Eventos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ProEventos.Api.Controllers;
using ProEventos.Core.Notifications.Interfaces;
using ProEventos.Core.Notifications;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos.Eventos;
using Xunit;

namespace ProEventos.UnitTest.Eventos.Controllers
{
    public class TestsEventosController_Get
    {
        [Fact(DisplayName = "GetAllEventosAsync OnSuccess ResturnsCode200")]
        [Trait("GET", "Eventos")]
        public async Task Get_OnSuccess_ResturnsCode200()
        {
            //Arrange
            var mockEventosService = IEventoServiceMock.SetupGetAllEventosAsync_ListEvents();
            var domainNotificationMock = new Mock<IDomainNotificationHandlerAsync<DomainNotification>>();
            var sut = new EventosController(domainNotificationMock.Object);

            //Act
            var result = await sut.Get(mockEventosService.Object);

            //Assert
            result.Result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult)result.Result!;
            objectResult.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact(DisplayName = "GetAllEventosAsync OnNoEventsFound ResturnsCode204")]
        [Trait("GET", "Eventos")]
        public async Task Get_OnNoEventsFound_ResturnsCode204()
        {
            //Arrange
            Mock<IEventoService>? mockEventosService = IEventoServiceMock.SetupGetAllEventosAsync_ListEmpty();
            var domainNotificationMock = new Mock<IDomainNotificationHandlerAsync<DomainNotification>>();
            var sut = new EventosController(domainNotificationMock.Object);

            //Act
            var result = await sut.Get(mockEventosService.Object);

            //Assert
            result.Result.Should().BeOfType<NoContentResult>();
            var objectResult = (NoContentResult)result.Result!;
            objectResult.StatusCode.Should().Be(StatusCodes.Status204NoContent);
        }

        [Fact(DisplayName = "Get OnSuccess InvokesUserServiceExactlyOnce")]
        [Trait("GET", "Eventos")]
        public async Task Get_OnSuccess_InvokesUserServiceExactlyOnce()
        {
            //Arrange
            var mockEventosService = IEventoServiceMock.SetupGetAllEventosAsync_ListEvents();
            var domainNotificationMock = new Mock<IDomainNotificationHandlerAsync<DomainNotification>>();
            var sut = new EventosController(domainNotificationMock.Object);

            //Act
            var result = await sut.Get(mockEventosService.Object);

            //Assert
            mockEventosService.Verify(service => service.GetAllEventosAsync(true), Times.Once());
        }

        [Fact(DisplayName = "Get OnSuccess ReturnsListOfEvents")]
        [Trait("GET", "Eventos")]
        public async Task Get_OnSuccess_ReturnsListOfEvents()
        {
            //Arrange
            var mockEventosService = IEventoServiceMock.SetupGetAllEventosAsync_ListEvents();
            var domainNotificationMock = new Mock<IDomainNotificationHandlerAsync<DomainNotification>>();
            var sut = new EventosController(domainNotificationMock.Object);

            //Act
            var result = await sut.Get(mockEventosService.Object);

            //Assert
            result.Result.Should().BeOfType<OkObjectResult>();
            var objectResulto = (OkObjectResult)result.Result!;
            objectResulto.Value.Should().NotBeNull();
            objectResulto.Value.Should().BeOfType<List<EventoDto>>();
        }

        [Fact(DisplayName = "GetById OnSuccess ResturnsCode200")]
        [Trait("GET", "Eventos")]
        public async Task GetById_OnSuccess_ResturnsCode200()
        {
            //Arrange
            var (mockEventosService, eventodto) = IEventoServiceMock.SetupGetByIdAsync();
            var domainNotificationMock = new Mock<IDomainNotificationHandlerAsync<DomainNotification>>();
            var sut = new EventosController(domainNotificationMock.Object);

            //Act
            var result = await sut.GetById(mockEventosService.Object, eventodto.Id);

            //Assert
            result.Result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult)result.Result!;
            objectResult.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact(DisplayName = "GetById OnNoEventFound ResturnsCode204")]
        [Trait("GET", "Eventos")]
        public async Task GetById_OnNoEventsFound_ResturnsCode204()
        {
            //Arrange
            var (mockEventosService, eventoDto) = IEventoServiceMock.SetupGetByIdAsync_NotFound();
            var domainNotificationMock = new Mock<IDomainNotificationHandlerAsync<DomainNotification>>();
            var sut = new EventosController(domainNotificationMock.Object);

            //Act
            var result = await sut.GetById(mockEventosService.Object, eventoDto!.Id);

            //Assert
            result.Result.Should().BeOfType<NoContentResult>();
            var objectResult = (NoContentResult)result.Result!;
            objectResult.StatusCode.Should().Be(StatusCodes.Status204NoContent);
        }

        [Fact(DisplayName = "GetById OnSuccess InvokesUserServiceExactlyOnce")]
        [Trait("GET", "Eventos")]
        public async Task GetById_OnSuccess_InvokesUserServiceExactlyOnce()
        {
            //Arrange
            var (mockEventosService, eventoDto) = IEventoServiceMock.SetupGetByIdAsync();
            var domainNotificationMock = new Mock<IDomainNotificationHandlerAsync<DomainNotification>>();
            var sut = new EventosController(domainNotificationMock.Object);

            //Act
            var result = await sut.GetById(mockEventosService.Object, eventoDto.Id);

            //Assert
            mockEventosService.Verify(service => service.Get(eventoDto.Id), Times.Once());
        }

        [Fact(DisplayName = "GetById OnSuccess ReturnEvent")]
        [Trait("GET", "Eventos")]
        public async Task GetById_OnSuccess_ReturnsListOfEvents()
        {
            //Arrange
            var (mockEventosService, eventoDto) = IEventoServiceMock.SetupGetByIdAsync();
            var domainNotificationMock = new Mock<IDomainNotificationHandlerAsync<DomainNotification>>();
            var sut = new EventosController(domainNotificationMock.Object);

            //Act
            var result = await sut.GetById(mockEventosService.Object, eventoDto.Id);

            //Assert
            result.Result.Should().BeOfType<OkObjectResult>();
            var objectResulto = (OkObjectResult)result.Result!;
            objectResulto.Value.Should().NotBeNull();
            objectResulto.Value.Should().BeOfType<EventoDto>();
        }
    }
}
