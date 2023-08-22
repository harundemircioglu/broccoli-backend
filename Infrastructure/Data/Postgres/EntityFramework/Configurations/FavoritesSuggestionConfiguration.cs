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
    public class FavoritesSuggestionConfiguration : IEntityTypeConfiguration<FavoritesSuggestion>
    {
        public void Configure(EntityTypeBuilder<FavoritesSuggestion> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.user_id).IsRequired();
            builder.Property(x=> x.suggestion_id).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.FavoritesSuggestions)
                .HasForeignKey(x => x.user_id);

            builder.HasOne(x => x.Suggestion)
                .WithMany(x => x.FavoritesSuggestions)
                .HasForeignKey(x => x.suggestion_id);
        }
    }
}
