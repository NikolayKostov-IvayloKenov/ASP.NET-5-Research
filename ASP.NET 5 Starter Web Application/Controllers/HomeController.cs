using System;
using System.Collections.Generic;
using System.Linq;
using ASP.NET_5_Starter_Web_Application.Models;
using ASP.NET_5_Starter_Web_Application.Services;
using Microsoft.AspNet.Mvc;

namespace ASP.NET_5_Starter_Web_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITimeProvider timeProvider;

        public HomeController(ApplicationDbContext context, ITimeProvider timeProvider)
        {
            this.timeProvider = timeProvider;
        }

        public IActionResult Index()
        {
            ViewBag.Time = timeProvider.GetTimeString();
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}