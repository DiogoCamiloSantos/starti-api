using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartiApi.Domain.Models;
using StartiApi.Services;

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

        [HttpGet("{id}")]
        public ActionResult<UserProfile> GetById(string id)
        {
            var userProfile = _userProfileService.GetById(id);
            if (userProfile == null)
            {
                return NotFound();
            }
            return Ok(userProfile);
        }

        [HttpPost]
        public ActionResult<UserProfile> Add(UserProfile userProfile)
        {
            _userProfileService.Add(userProfile);
            return CreatedAtAction(nameof(GetById), new { id = userProfile.Id }, userProfile);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, UserProfile userProfile)
        {
            if (id != userProfile.Id)
            {
                return BadRequest();
            }

            var existingUserProfile = _userProfileService.GetById(id);
            if (existingUserProfile == null)
            {
                return NotFound();
            }

            _userProfileService.Update(userProfile);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var userProfile = _userProfileService.GetById(id);
            if (userProfile == null)
            {
                return NotFound();
            }

            _userProfileService.Delete(id);
            return NoContent();
        }
    }
}
