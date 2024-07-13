using Starti.Domain.Entities;

namespace Starti.Application.Services.interfaces
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> GetAllAsync();
        Task AddManyAsync(IEnumerable<Article> articles);
        Task<IEnumerable<Article>> SearchAsync(string searchTerm);
    }
}
