using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PRController : ControllerBase
    {
        [HttpGet("message")]
        public IActionResult GetMessage()
        {
            return Ok("Hello from PRController!");
        }
    }
}
