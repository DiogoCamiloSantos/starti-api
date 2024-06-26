using System.Collections.Generic;
using System.Threading.Tasks;
using StartiApi.Domain.Models;
using StartiApi.Repositories;

public class ArticleService : IArticleService
{
    private readonly IArticleRepository articleRepository;

    public ArticleService(IArticleRepository articleRepository)
    {
        this.articleRepository = articleRepository;
    }

    public Task<IEnumerable<Article>> GetAsync()
    {
        return articleRepository.GetAsync();
    }
}
