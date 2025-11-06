using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
            return Ok("Register endpoint hit");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok("Register endpoint hit");
        }
    }
}
