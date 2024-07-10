using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Starti.Persistence.Data;
using Starti.Persistence.Data.Interfaces;
using Starti.Persistence.Repositories;
using Starti.Repositories.Interfaces;

namespace Starti.Persistence.Registration
{
    public static class PersistenceConfigurationService
    {
        public static void AddPersistenceConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var dbProvider = configuration.GetValue<string>("DatabaseProvider");
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var configurerType = DbContextConfigurerMap.GetType(dbProvider);
            services.AddScoped(typeof(IDbContextConfigurer), configurerType);

            services.AddDbContext<AppDbContext>(options =>
            {
                var configurer = (IDbContextConfigurer)Activator.CreateInstance(configurerType);
                configurer.Configure(options, connectionString);
            });

            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IUserProfileRepository, UserProfileRepository>();
        }
    }
}
