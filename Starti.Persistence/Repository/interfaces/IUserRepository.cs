using System.Collections.Generic;
using Starti.Domain.Entities;

namespace Starti.Repositories.Interfaces
{
    public interface IUserProfileRepository
    {
        IEnumerable<UserProfile> GetAll();
        UserProfile GetBy(string id);
        Task<IEnumerable<UserProfile>> GetAsyncBy(string search);
        void Add(UserProfile userProfile);
        void Update(UserProfile userProfile);
        void Delete(string id);
    }
}
