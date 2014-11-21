using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_6_in_VS_2015_Preview
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
