using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_6_RC_1.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
