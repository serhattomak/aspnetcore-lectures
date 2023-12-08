using System;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour; 

            // ViewBag.Greeting = hour > 12 ? "Have a nice day": "Good Morning";
            // ViewBag.UserName = "Serhat";

            ViewData["Greeting"] = hour > 12 ? "Have a nice day": "Good Morning";
            ViewData["UserName"] = "Serhat";

            return View();
        }
    }
}