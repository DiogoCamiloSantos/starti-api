using System.Collections.Generic;
using System.Linq;
using StartiApi.Domain.Domain.Entities;

public class ArticlePresenter
{
    public static IEnumerable<object> Present(IEnumerable<Article> articles)
    {
        return articles.Select(article => new
        {
            article.Id,
            article.Title,
            article.Content,
            article.Author,
            CreatedAt = article.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"),
            UpdatedAt = article.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss")
        });
    }
}
