using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;
public class HoangManhTungController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
