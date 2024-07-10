using Starti.Domain.Entities;

namespace Starti.Application.Services.Interfaces
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
