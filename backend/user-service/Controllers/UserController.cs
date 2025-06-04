using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("health")]
    public IActionResult Health() => Ok("UserService OK");
}
