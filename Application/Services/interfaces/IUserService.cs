using System.Collections.Generic;
using StartiApi.Domain.Models;

namespace StartiApi.Services
{
    public interface IUserProfileService
    {
        IEnumerable<UserProfile> GetAll();
        Task<IEnumerable<UserProfile>> GetAsyncBy(string search);
        UserProfile GetBy(string id);
        void Add(UserProfile userProfile);
        void Update(UserProfile userProfile);
        void Delete(string id);
    }
}
