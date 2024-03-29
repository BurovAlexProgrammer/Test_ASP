﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Domain.Models;

namespace TestApp.DAL.Postgres.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<NewsEntity>
    {
        public void Configure(EntityTypeBuilder<NewsEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasOne(x => x.Author)
                .WithMany(x => x.News)
                .HasForeignKey(x => x.AuthorId);
        }
    }
}