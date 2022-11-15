using ProEventos.Core.Notifications.Interfaces;

namespace ProEventos.Core.Notifications.Implementation
{
    public class Notifications : INotifications
    {
        public List<string> _notifications { get; set; } = new();

        public bool HasNotifications => _notifications.Any();

        IReadOnlyCollection<string> INotifications.Notifications => _notifications;

        public void AddNotification(IReadOnlyCollection<string> messages)
        {
            messages.ToList().ForEach(erro => _notifications.Add(erro));
        }
    }
}
