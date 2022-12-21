namespace ProEventos.Core.Notifications.Interfaces
{
    public interface IDomainNotificationHandlerAsync<T> : IHandlerAsync<T>
    {
        bool HasNotifications();
        List<T> GetNotifications();
        void Clean();
    }
}
