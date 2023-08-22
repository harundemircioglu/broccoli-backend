using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class FavoritesPostConfiguration : IEntityTypeConfiguration<FavoritesPost>
    {
        public void Configure(EntityTypeBuilder<FavoritesPost> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.user_id).IsRequired();
            builder.Property(x => x.post_id).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.FavoritesPosts)
                .HasForeignKey(x => x.user_id);

            builder.HasOne(x => x.Post)
                .WithMany(x => x.FavoritesPosts)
                .HasForeignKey(x => x.post_id);

            //Bir favoriyi birden fazla favori eklemeyi engellemek için unique index ekleme
            builder.HasIndex(x => new { x.user_id, x.post_id }).IsUnique();
        }
    }
}
