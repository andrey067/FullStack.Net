using ProEventos.Core.Notifications.Enums;

namespace ProEventos.Core.Notifications
{
    public class DomainNotification
    {
        public string Key { get; }

        public string Value { get; }

        public DomainNotification(TipoDeNotificacao key, string value)
        {
            Key = key.ToString();
            Value = value;
        }
    }
}
