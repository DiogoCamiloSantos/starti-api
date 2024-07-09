using System.Collections.Generic;
using System.Threading.Tasks;
using Starti.Domain.Entities;
using StartiApi.Repositories;
using StartiApi.Repositories.Interfaces;

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
}
