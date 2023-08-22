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
    public class RecommendedPostsImageConfiguration : IEntityTypeConfiguration<RecommendedPostsImage>
    {
        public void Configure(EntityTypeBuilder<RecommendedPostsImage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.recommended_post_id).IsRequired();
            builder.Property(x => x.image_url).IsRequired();

            builder.HasOne(x => x.RecommendedPost)
                .WithMany(x => x.RecommendedPostsImages)
                .HasForeignKey(x => x.recommended_post_id);
        }
    }
}
