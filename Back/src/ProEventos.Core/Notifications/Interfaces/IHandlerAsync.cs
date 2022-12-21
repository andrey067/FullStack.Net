namespace ProEventos.Core.Notifications.Interfaces
{
    public interface IHandlerAsync<T>
    {
        Task HandleAsync(T message);
    }
}
