using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.Logging;

namespace ASP.NET_5_Starter_Web_Application.Middlewares
{
    public class ApplicationHeaderMiddleware
    {
        private readonly RequestDelegate next;

        public ApplicationHeaderMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.Headers.Append("X-Application", "ASP.NET 5 Sample App");
            await this.next.Invoke(context);
        }
    }
}