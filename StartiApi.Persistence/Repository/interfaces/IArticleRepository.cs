using System.Collections.Generic;
using System.Threading.Tasks;
using Starti.Domain.Entities;

namespace StartiApi.Repositories.Interfaces
{
    public interface IArticleRepository
    {
        Task<Article> GetArticleByIdAsync(int id);
        Task<IEnumerable<Article>> GetAllAsync();
        Task AddArticleAsync(Article article);
        Task UpdateArticleAsync(Article article);
        Task DeleteArticleAsync(int id);
        Task AddManyAsync(IEnumerable<Article> articles);
    }
}
