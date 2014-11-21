using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace ASP.NET_5_Empty_Application
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                context.Response.ContentType = "text/html";
                context.Response.StatusCode = 200;
#if ASPNET50
                var frameworkInfo = string.Format("<h1>ASP.NET 5 on .NET Framework</h1>");
                var timeInfo = string.Format("<h2>The time now is: {0}</h1>", NodaTime.SystemClock.Instance.Now);
#elif ASPNETCORE50
                var frameworkInfo = string.Format("<h1>ASP.NET Core on .NET Core</h1>");
                var timeInfo = string.Format("<h2>The time now is: {0}</h1>", DateTime.Now.ToString());
#endif
                await context.Response.WriteAsync(frameworkInfo);
                await context.Response.WriteAsync(timeInfo);
            });
        }
    }
}
