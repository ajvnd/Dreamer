using Microsoft.AspNetCore.Mvc;

namespace Dreamer.Presentation.Api.Controllers;

public class SampleController : Controller
{
    public IActionResult Get()
    {
        return Ok();
    }
}