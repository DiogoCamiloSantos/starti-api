using StartiApi.Domain.Domain.Entities;

public interface IArticleService
{
    Task<IEnumerable<Article>> GetAsync();
}
