using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}