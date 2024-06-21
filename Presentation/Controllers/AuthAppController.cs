using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartiApi.Application.Interfaces;
using StartiApi.Domain.Models;

namespace StartiApi.Presentation.Controllers
{    
    [Route("api/app/auth")]
    [ApiController]
    public class AuthAppController : ControllerBase
    {
        private readonly IAuthenticationService _userService;

        public AuthAppController(IAuthenticationService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserLogin user)
        {
            var token = _userService.Authenticate(user.Username, user.Password, "app");

            if (token == null)
                return Unauthorized();

            return Ok(new { Token = token });
        }
    }
}
