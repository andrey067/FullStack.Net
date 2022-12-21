using System.Threading.Tasks;
using FluentValidation.Results;
using ProEventos.Core.Notifications;
using ProEventos.Core.Notifications.Enums;
using ProEventos.Core.Notifications.Interfaces;

namespace ProEventos.Services.Services
{
    public abstract class DomainService
    {
        protected readonly IDomainNotificationHandlerAsync<DomainNotification> _notificacaoDeDominio;

        protected DomainService(IDomainNotificationHandlerAsync<DomainNotification> notificacaoDeDominio) => _notificacaoDeDominio = notificacaoDeDominio;

        public async Task NotificarValidacoesDeDominio(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
                await _notificacaoDeDominio.HandleAsync(new DomainNotification(TipoDeNotificacao.ErroDeDominio, erro.ErrorMessage));
        }
    }
}
