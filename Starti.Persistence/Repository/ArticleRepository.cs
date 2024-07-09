using Microsoft.EntityFrameworkCore;
using Starti.Domain.Entities;
using Starti.Persistence.Data;
using StartiApi.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Starti.Persistence.Repositories
{
    internal class ArticleRepository : IArticleRepository
    {
        private readonly AppDbContext context;

        public ArticleRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Article> GetArticleByIdAsync(int id)
        {
            return await context.Articles.FindAsync(id);
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            return await context.Articles.ToListAsync();
        }

        public async Task AddArticleAsync(Article article)
        {
            await context.Articles.AddAsync(article);
            await context.SaveChangesAsync();
        }

        public async Task UpdateArticleAsync(Article article)
        {
            context.Articles.Update(article);
            await context.SaveChangesAsync();
        }

        public async Task DeleteArticleAsync(int id)
        {
            var article = await context.Articles.FindAsync(id);
            if (article != null)
            {
                context.Articles.Remove(article);
                await context.SaveChangesAsync();
            }
        }

        public async Task AddManyAsync(IEnumerable<Article> articles)
        {
            await context.Articles.AddRangeAsync(articles);
            context.SaveChanges();
        }
    }
}
