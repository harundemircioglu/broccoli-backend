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
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.user_id).IsRequired();
            builder.Property(x => x.category_id).IsRequired();
            builder.Property(x => x.post_header).IsRequired();
            builder.Property(x => x.post_detail).IsRequired();
            builder.Property(x => x.popularity).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.user_id);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.category_id);

            builder.HasMany(x => x.Comments)
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.post_id);

            builder.HasMany(x => x.FavoritesPosts)
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.post_id);

            builder.HasMany(x => x.PostsImages)
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.post_id);
        }
    }
}
