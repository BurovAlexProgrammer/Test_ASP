using Microsoft.EntityFrameworkCore;
using TestApp.Core.Postgres.Configurations;
using TestApp.Core.Postgres.Models;

namespace TestApp.Core.Postgres
{
    public class AppDbContext : DbContext
    {
        public DbSet<AuthorEntity> Authors;
        public DbSet<NewsEntity> News;

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new NewsConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}