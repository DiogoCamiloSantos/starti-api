using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Starti.Persistence.Data.Interfaces;
using Starti.Domain.Entities;
using Starti.Domain.Extensions;

namespace Starti.Persistence.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IDbContextConfigurer dbContextConfigurer;
        private readonly string connectionString = "";
        public DbSet<Article> Articles { get; set; }

        public AppDbContext(
            DbContextOptions<AppDbContext> options,
            IDbContextConfigurer dbContextConfigurer,
            IConfiguration configuration)
            : base(options)
        {
            this.dbContextConfigurer = dbContextConfigurer;

            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                dbContextConfigurer.Configure(optionsBuilder, connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Id)
                      .HasColumnName("id")
                      .HasDefaultValueSql("uuid_generate_v4()");
            });

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.Name.ToSnakeCase());
                }

                foreach (var key in entity.GetKeys())
                {
                    key.SetName(key.GetName().ToSnakeCase());
                }

                foreach (var foreignKey in entity.GetForeignKeys())
                {
                    foreignKey.SetConstraintName(foreignKey.GetConstraintName().ToSnakeCase());
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.SetDatabaseName(index.GetDatabaseName().ToSnakeCase());
                }
            }
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; 

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }
    }
}
