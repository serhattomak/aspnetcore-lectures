using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    //course
    //course/index
    public IActionResult Index()
    {
        var course=new Course();
        course.Id=1;
        course.Title="ASP.NET Core Course";
        course.Description="ASP.NET Core Course Description";
        course.Image="1.jpg";
        return View(course);
    }

    public IActionResult Details()
    {
        var course=new Course();
        course.Id=2;
        course.Title="PHP Course";
        course.Description="PHP Course Description";
        course.Image="2.jpg";
        return View(course);
    }
    //course/list
    public IActionResult List()
    {
        
        return View("CourseList", Repository.Courses);
    }
}