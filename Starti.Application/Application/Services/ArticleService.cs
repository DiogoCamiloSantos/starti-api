using Starti.Application.Services.interfaces;
using Starti.Domain.Entities;
using Starti.Repositories.Interfaces;

namespace Starti.Application.Services
{
    public class ArticleService : IArticleService
    {
        internal readonly IArticleRepository articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public Task AddManyAsync(IEnumerable<Article> articles)
        {
            return articleRepository.AddManyAsync(articles);
        }

        public Task<IEnumerable<Article>> GetAllAsync()
        {
            return articleRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Article>> SearchAsync(string searchTerm)
        {
            return await articleRepository.GetByAsync(searchTerm);
        }
    }
}