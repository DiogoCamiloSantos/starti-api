using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
    public async Task<IActionResult> GetArticles()
    {
        var articles = await articleService.GetAsync();
        var result = ArticlePresenter.Present(articles);
        return Ok(result);
    }
}
