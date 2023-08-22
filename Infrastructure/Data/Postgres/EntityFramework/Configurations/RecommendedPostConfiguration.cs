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
    public class RecommendedPostConfiguration : IEntityTypeConfiguration<RecommendedPost>
    {
        public void Configure(EntityTypeBuilder<RecommendedPost> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.post_header).IsRequired();
            builder.Property(x => x.post_detail).IsRequired();
            builder.Property(x => x.category_id).IsRequired();
            builder.Property(x => x.popularity).IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.RecommendedPosts)
                .HasForeignKey(x => x.category_id);

            builder.HasMany(x => x.RecommendedPostsImages)
                .WithOne(x => x.RecommendedPost)
                .HasForeignKey(x => x.recommended_post_id);

            builder.HasMany(x => x.FavoritesRecommendedPosts)
                .WithOne(x => x.RecommendedPost)
                .HasForeignKey(x => x.recommended_post_id);
        }
    }
}
