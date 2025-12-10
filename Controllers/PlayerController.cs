using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPlayers()
        {
            var players = new[] { "Steve", "Alex", "Herobrine" };
            return Ok(players);
        }
    }
}