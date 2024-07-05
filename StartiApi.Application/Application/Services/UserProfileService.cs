using System.Collections.Generic;
using StartiApi.Domain.Domain.Entities;
using StartiApi.Repositories;

namespace StartiApi.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public IEnumerable<UserProfile> GetAll()
        {
            return _userProfileRepository.GetAll();
        }

        public UserProfile GetBy(string id)
        {
            return _userProfileRepository.GetBy(id);
        }

        public void Add(UserProfile userProfile)
        {
            _userProfileRepository.Add(userProfile);
        }

        public void Update(UserProfile userProfile)
        {
            _userProfileRepository.Update(userProfile);
        }

        public void Delete(string id)
        {
            _userProfileRepository.Delete(id);
        }

        public Task<IEnumerable<UserProfile>> GetAsyncBy(string search)
        {
            return _userProfileRepository.GetAsyncBy(search);
        }
    }
}
