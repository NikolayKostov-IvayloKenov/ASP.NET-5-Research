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

                await context.Response.WriteAsync(string.Format("<h1>The time now is: {0}</h1>", DateTime.Now.ToString()));
            });
        }
    }
}
