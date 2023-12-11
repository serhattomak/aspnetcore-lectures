using System;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour; 

            ViewData["Greeting"] = hour > 12 ? "Have a nice day": "Good Morning";
            // ViewData["UserName"] = "Serhat";

            var meetingInfo=new MeetingInfo()
            {
                Id=1,
                Location="İstanbul, ABC Congress Centre",
                Date= new DateTime(2024,01,20,20,0,0),
                NumberOfPeople=100
            };

            return View(meetingInfo);
        }
    }
}