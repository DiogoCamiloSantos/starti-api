using Microsoft.AspNetCore.Mvc;
using Starti.Application.Services.interfaces;
using Starti.WebApi.Presentation.Presenters.DTOs.Article;

[ApiController]
[Route("api/[controller]")]
public class ArticlesController : ControllerBase
{
    private readonly IArticleService articleService;

    public ArticlesController(IArticleService articleService)
    {
        this.articleService = articleService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var articles = await articleService.GetAllAsync();
        var result = ArticlePresenter.Present(articles);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddMany([FromBody] ArticleDTO[] articles)
    {
        await articleService.AddManyAsync(articles.Select(article => ArticlePresenter.FromDto(article)));
        return Ok();
    }
}
