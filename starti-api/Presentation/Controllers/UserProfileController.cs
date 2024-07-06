using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartiApi.Services;
using StartiApi.Presentation.Presenters.DTO;
using StartiApi.Domain.Domain.Entities;

namespace StartiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserProfile>> GetAll()
        {
            var userProfiles = _userProfileService.GetAll();
            return Ok(userProfiles);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<UserProfile>>> Search([FromBody] UserProfileSearchDTO userProfileDTO)
        {
            var userProfiles = await _userProfileService.GetAsyncBy(userProfileDTO.Search);

            if (userProfiles == null)
                return NotFound();

            return Ok(userProfiles);
        }
    }
}