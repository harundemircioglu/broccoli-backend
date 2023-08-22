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
    public class SuggestionConfiguration : IEntityTypeConfiguration<Suggestion>
    {
        public void Configure(EntityTypeBuilder<Suggestion> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.suggestion_header).IsRequired();
            builder.Property(x => x.suggestion_detail).IsRequired();
            builder.Property(x => x.category_id).IsRequired();
            builder.Property(x => x.popularity).IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Suggestions)
                .HasForeignKey(x => x.category_id);

            builder.HasMany(x => x.SuggestionsImages)
                .WithOne(x => x.Suggestion)
                .HasForeignKey(x => x.suggestion_id);

            builder.HasMany(x => x.FavoritesSuggestions)
                .WithOne(x => x.Suggestion)
                .HasForeignKey(x => x.suggestion_id);
        }
    }
}
