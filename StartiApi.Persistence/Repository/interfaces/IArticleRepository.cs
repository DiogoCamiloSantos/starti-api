using System.Collections.Generic;
using System.Threading.Tasks;
using StartiApi.Domain.Domain.Entities;

namespace StartiApi.Repositories
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetAsync();
    }
}
