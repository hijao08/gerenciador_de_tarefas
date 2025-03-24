using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("OII, TE AMO TUTU!");
    }
}
