using DemoMvc.Data;
using DemoMvc.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;
public class StudentController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Student std)
    {
        ViewBag.message = std.StudentID + "-" + std.FullName;
        return View();
    }
    public IActionResult Demo()
    {
        return View();
    }
}