using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class VaultController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Ping() => Ok("VaultService OK");
}
