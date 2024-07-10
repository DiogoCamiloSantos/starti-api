using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Starti.Domain.Entities;

namespace Starti.Presentation.Controllers
{
    [Route("api/app/auth")]
    [ApiController]
    public class AuthAppController : ControllerBase
    {
        private readonly IAuthenticationService jwtService;

        public AuthAppController(IAuthenticationService jwtService)
        {
            this.jwtService = jwtService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserLogin user)
        {
            var token = jwtService.GenerateToken(user.Username, "app");

            if (token == null)
                return Unauthorized();

            return Ok(new { Token = token });
        }
    }
}
 