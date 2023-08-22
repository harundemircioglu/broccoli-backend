using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.name).IsRequired();
        builder.Property(x => x.email).IsRequired();
        builder.HasIndex(x => x.email).IsUnique();
        builder.Property(x => x.phone).IsRequired();
        builder.Property(x => x.phone).IsRequired();
        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.PasswordSalt).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.IsDeleted).IsRequired();

        builder.HasMany(x => x.Comments)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.user_id);

        builder.HasMany(x => x.FavoritesPosts)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.user_id);

        builder.HasMany(x => x.FavoritesRecommendedPosts)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.user_id);

        builder.HasMany(x => x.FavoritesSuggestions)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.user_id);

        builder.HasMany(x => x.Posts)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.user_id);

        builder.HasMany(x => x.WeightsTrackings)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.user_id);
    }
}