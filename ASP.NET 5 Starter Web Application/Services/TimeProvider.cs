using System;

namespace ASP.NET_5_Starter_Web_Application.Services
{
    public class TimeProvider : ITimeProvider
    {
        public string GetTimeString()
        {
            return DateTime.Now.ToString();
        }
    }
}