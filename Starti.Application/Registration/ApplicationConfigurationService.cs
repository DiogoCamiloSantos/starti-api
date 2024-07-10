using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Starti.Application.Services;
using Starti.Application.Services.interfaces;
using Starti.Application.Services.Interfaces;
using Starti.Persistence.Registration;
using Starti.Services;

namespace Starti.Application.Registration
{
    public static class ApplicationConfigurationService
    {
        public static void AddApplicationConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistenceConfiguration(configuration);
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IUserProfileService, UserProfileService>();
        }
    }
}
