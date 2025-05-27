using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("user")]
public class AuthController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Ping() => Ok("UserService OK");
}
