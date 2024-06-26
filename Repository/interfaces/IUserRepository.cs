using System.Collections.Generic;
using StartiApi.Domain.Models;

namespace StartiApi.Repositories
{
    public interface IUserProfileRepository
    {
        IEnumerable<UserProfile> GetAll();
        UserProfile GetById(string id);
        void Add(UserProfile userProfile);
        void Update(UserProfile userProfile);
        void Delete(string id);
    }
}
