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
    public class SuggestionsImageConfiguration : IEntityTypeConfiguration<SuggestionsImage>
    {
        public void Configure(EntityTypeBuilder<SuggestionsImage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.suggestion_id).IsRequired();
            builder.Property(x => x.image_url).IsRequired();

            builder.HasOne(x => x.Suggestion)
                .WithMany(x => x.SuggestionsImages)
                .HasForeignKey(x => x.suggestion_id);
        }
    }
}
