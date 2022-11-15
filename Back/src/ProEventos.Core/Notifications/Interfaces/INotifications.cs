namespace ProEventos.Core.Notifications.Interfaces
{
    public interface INotifications
    {
        List<string> _notifications { get; }
        public IReadOnlyCollection<string> Notifications { get; }
        public bool HasNotifications { get; }

        void AddNotification(IReadOnlyCollection<string> message);
    }
}
