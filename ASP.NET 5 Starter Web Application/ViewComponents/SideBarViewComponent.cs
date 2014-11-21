using System;
using System.Collections;
using Microsoft.AspNet.Mvc;
using System.Linq;

namespace ASP.NET_5_Starter_Web_Application.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        public SideBarViewComponent()
        {
        }

        public IViewComponentResult Invoke(int numbers)
        {
            var items = Enumerable.Range(1, numbers).ToList();

            return this.View(items);
        }
    }
}