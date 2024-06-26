using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartiApi.Application.Interfaces;
using StartiApi.Domain.Models;

namespace StartiApi.Presentation.Controllers
{
    [Route("api/site/auth")]
    [ApiController]
    public class AuthSiteController : ControllerBase
    {
        private readonly IAuthenticationService _userService;

        public AuthSiteController(IAuthenticationService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Login pelo site.
        /// </summary>
        /// <returns>Chave JWT.</returns>
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserLogin user)
        {
            var token = _userService.Authenticate(user.Username, user.Password, "site");

            if (token == null)
                return Unauthorized();

            return Ok(new { Token = token });
        }
    }
}
