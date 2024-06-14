using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartiApi.Application.Interfaces;

namespace StartiApi.Presentation.Controllers
{    
    [Route("api/app/auth")]
    [ApiController]
    public class AuthAppController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthAppController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserModel user)
        {
            var token = _userService.Authenticate(user.Username, user.Password, "app");

            if (token == null)
                return Unauthorized();

            return Ok(new { Token = token });
        }
    }
}
