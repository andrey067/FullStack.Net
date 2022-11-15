using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using ProEventos.Api.Utilities;
using ProEventos.Core.Notifications.Interfaces;

namespace ProEventos.Api.Filters
{
    public class NotificationFilter : IAsyncResultFilter
    {
        private readonly INotifications _notifications;

        public NotificationFilter(INotifications notifications)
        {
            _notifications = notifications;
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (_notifications.HasNotifications)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.HttpContext.Response.ContentType = "application/json";

                var notifications = JsonConvert.SerializeObject(Responses.DomainErrorMessage(_notifications.Notifications));
                await context.HttpContext.Response.WriteAsync(notifications);

                return;
            }

            await next();
        }
    }
}
