using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Ping() => Ok("UserService OK");
}
