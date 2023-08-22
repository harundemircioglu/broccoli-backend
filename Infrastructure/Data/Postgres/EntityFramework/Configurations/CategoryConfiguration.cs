using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.category_name).IsRequired();
            builder.HasIndex(c => c.category_name).IsUnique();
            builder.Property(c => c.popularity).IsRequired();

            builder.HasMany(x => x.Posts)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.category_id);

            builder.HasMany(x => x.Suggestions)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.category_id);

            builder.HasMany(x => x.RecommendedPosts)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.category_id);
        }
    }
}
