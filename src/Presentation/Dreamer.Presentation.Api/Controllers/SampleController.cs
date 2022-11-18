using Microsoft.AspNetCore.Mvc;

namespace Dreamer.Presentation.Api.Controllers;

[ApiController]
public class SampleController : Controller
{
    public IActionResult Get()
    {
        return Ok();
    }
}