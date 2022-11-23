using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using ProEventos.Api.Utilities;

namespace ProEventos.Api.Filters
{
    public class ResponseFilter : IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            switch (context.HttpContext.Response.StatusCode)
            {
                case (int)HttpStatusCode.OK:
                    context.HttpContext.Response.ContentType = "application/json";
                    var resultOK = JsonConvert.SerializeObject(Responses.HttpStatusCodeOK(((OkObjectResult)context.Result).Value));

                    await context.HttpContext.Response.WriteAsync(resultOK);
                    break;

                case (int)HttpStatusCode.NoContent:
                    context.HttpContext.Response.ContentType = "application/json";
                    var resultNoContent = JsonConvert.SerializeObject(Responses.HttpStatusCodeNoContent());

                    await context.HttpContext.Response.WriteAsync(resultNoContent);
                    break;

                default:
                    await next();
                    break;
            }
        }
    }
}
