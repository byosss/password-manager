using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("vault")]
public class AuthController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Ping() => Ok("VaultService OK");
}
