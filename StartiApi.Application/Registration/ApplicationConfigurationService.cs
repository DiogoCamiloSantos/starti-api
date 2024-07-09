using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StartiApi.Persistence.Registration;

namespace StartiApi.Application.Registration
{
    public static class ApplicationConfigurationService
    {
        public static void AddApplicationConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistenceConfiguration(configuration);
            services.AddScoped<IArticleService, ArticleService>();
        }
    }
}
