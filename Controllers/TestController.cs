using Microsoft.AspNetCore.Mvc;

namespace NextDaemon;

[Route("api/[controller]")]
[ApiController]

public class TestController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> GetHelloWorld()
    {
        return Ok("Hello from Controller!");
    } 
}
