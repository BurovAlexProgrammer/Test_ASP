using Microsoft.EntityFrameworkCore;
using TestApp.DAL.Postgres.Configurations;
using TestApp.Domain.Models;

namespace TestApp.DAL.Postgres
{
    public class PostgresDbContext : DbContext
    {
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<NewsEntity> News { get; set; }

        public PostgresDbContext(DbContextOptions options) : base(options)
        {
            // TODO For debug ef - uncomment
            // Console.Out.WriteLine("Current ProcessID: " + Process.GetCurrentProcess().Id); //This prints the process id
            // Console.Out.WriteLine("Waiting for debugger to attach...");
            // while (!Debugger.IsAttached)
            // {
            //     Thread.Sleep(100);
            // }
            // Console.Out.WriteLine("Debugger attached!");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new NewsConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}