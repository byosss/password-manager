using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class VaultController : ControllerBase
{
    [HttpGet("health")]
    public IActionResult Health() => Ok("VaultService OK");
}
