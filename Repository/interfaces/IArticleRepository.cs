using System.Collections.Generic;
using System.Threading.Tasks;
using StartiApi.Domain.Models;

namespace StartiApi.Repositories
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetAsync();
    }
}
