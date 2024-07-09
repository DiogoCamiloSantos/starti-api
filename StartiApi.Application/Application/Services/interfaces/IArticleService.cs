using Starti.Domain.Entities;

public interface IArticleService
{
    Task<IEnumerable<Article>> GetAllAsync();
    Task AddManyAsync(IEnumerable<Article> articles);
}
