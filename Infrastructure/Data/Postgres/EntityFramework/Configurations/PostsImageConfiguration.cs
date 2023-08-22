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
    public class PostsImageConfiguration : IEntityTypeConfiguration<PostsImage>
    {
        public void Configure(EntityTypeBuilder<PostsImage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.post_id).IsRequired();
            builder.Property(x => x.image_url).IsRequired();

            builder.HasOne(x => x.Post)
                .WithMany(x => x.PostsImages)
                .HasForeignKey(x => x.post_id);
        }
    }
}
