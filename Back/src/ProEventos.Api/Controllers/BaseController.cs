using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Core.Notifications;
using ProEventos.Core.Notifications.Interfaces;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        protected readonly IDomainNotificationHandlerAsync<DomainNotification> _notificacaoDeDominio;

        public BaseController(IDomainNotificationHandlerAsync<DomainNotification> notificacaoDeDominio) => _notificacaoDeDominio = notificacaoDeDominio;

        protected bool OperacaoValida() => !_notificacaoDeDominio.HasNotifications();

        protected BadRequestObjectResult BadRequestResponse()
        {
            return BadRequest(_notificacaoDeDominio.GetNotifications().Select(n => n.Value));
        }

    }
}
