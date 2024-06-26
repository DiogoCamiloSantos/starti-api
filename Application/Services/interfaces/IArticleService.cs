using StartiApi.Domain.Models;

public interface IArticleService
{
    Task<IEnumerable<Article>> GetAsync();
}
