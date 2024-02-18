using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Domain.Models;

namespace TestApp.DAL.Postgres.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<AuthorEntity>
    {
        public void Configure(EntityTypeBuilder<AuthorEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.News).WithOne(x => x.Author);
        }
    }
}