using Microsoft.AspNetCore.Mvc;

namespace Dreamer.Presentation.WebApp.Controllers;

[ApiController]
public class SampleController : Controller
{
    public IActionResult Get()
    {
        return Ok();
    }
}