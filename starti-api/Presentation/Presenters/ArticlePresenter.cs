using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Starti.Domain.Entities;

public class ArticlePresenter
{
    public static IEnumerable<object> Present(IEnumerable<Article> articles)
    {
        return articles.Select(article => ToDto(article));
    }
    public static object ToDto(Article article)
    {
        return new
        {
            article.Id,
            article.Title,
            article.Content,
            article.Author,
            CreatedAt = article.CreatedAt.ToString(),
            UpdatedAt = article.UpdatedAt.ToString()
        };
    }

    public static Article FromDto(object dto)
    {
        var dtoObj = (dynamic)dto;
        return new Article
        {
            Title = dtoObj.title,
            Content = dtoObj.content,
            Author = dtoObj.author
        };
    }
}
