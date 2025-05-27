using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/vault")]
public class AuthController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Ping() => Ok("VaultService OK");
}
