using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Starti.Domain.Entities;

namespace StartiApi.Presentation.Controllers
{
    [Route("api/site/auth")]
    [ApiController]
    public class AuthSiteController : ControllerBase
    {
        private readonly IAuthenticationService jwtService;

        public AuthSiteController(IAuthenticationService jwtService)
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
