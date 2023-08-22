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
    public class FavoritesRecommendedPostConfiguration : IEntityTypeConfiguration<FavoritesRecommendedPost>
    {
        public void Configure(EntityTypeBuilder<FavoritesRecommendedPost> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.user_id).IsRequired();
            builder.Property(x => x.recommended_post_id).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.FavoritesRecommendedPosts)
                .HasForeignKey(x => x.user_id);

            builder.HasOne(x => x.RecommendedPost)
                .WithMany(x => x.FavoritesRecommendedPosts)
                .HasForeignKey(x => x.recommended_post_id);
        }
    }
}
