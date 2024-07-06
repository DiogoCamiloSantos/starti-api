using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartiApi.Application.Interfaces;
using StartiApi.Domain.Domain.Entities;

namespace StartiApi.Presentation.Controllers
{
    [Route("api/app/auth")]
    [ApiController]
    public class AuthAppController : ControllerBase
    {
        private readonly IAuthenticationService jwtService;

        public AuthAppController(IAuthenticationService jwtService)
        {
            jwtService = jwtService;
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
 