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
        return View(course);
    }
    //course/list
    public IActionResult List()
    {
        var courses=new List<Course>()
        {
            new Course() { Id = 1, Title="ASP.NET Core Course", Description="ASP.NET Core Course Description"},
            new Course() { Id = 2, Title="PHP Course", Description="PHP Course Description"},
            new Course() { Id = 3, Title="Django Course", Description="Django Course Description"},
            new Course() { Id = 4, Title="JavaScript Course", Description="JavaScript Course Description"}
        };
        return View("CourseList", courses);
    }
}