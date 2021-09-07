using Microsoft.AspNetCore.Mvc;

namespace Ratchet.Web.Application.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("current")]
        public IActionResult Current()
        {
            return Ok(new
            {
                Status = "OK",
                Subscriber = "Test"
            });
        }
    }
}