using Microsoft.AspNetCore.Mvc;

namespace Dreamer.Presentation.WebApp.Controllers;

public class SampleController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}