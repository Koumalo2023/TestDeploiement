using Microsoft.AspNetCore.Mvc;

namespace CinephoriaServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        // GET: api/test/connection
        [HttpGet("connection")]
        public IActionResult CheckConnection()
        {
            return Ok(new
            {
                Message = "Connexion réussie entre le backend et le frontend !",
                Timestamp = DateTime.UtcNow
            });
        }
    }
}