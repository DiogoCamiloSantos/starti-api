using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartiApi.Application.Interfaces;

namespace StartiApi.Presentation.Controllers
{
    [Route("api/site/auth")]
    [ApiController]
    public class AuthSiteController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthSiteController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Login pelo site.
        /// </summary>
        /// <returns>Chave JWT.</returns>
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserModel user)
        {
            var token = _userService.Authenticate(user.Username, user.Password, "site");

            if (token == null)
                return Unauthorized();

            return Ok(new { Token = token });
        }
    }
}
