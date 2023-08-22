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
    public class WeightsTrackingConfiguration : IEntityTypeConfiguration<WeightsTracking>
    {
        public void Configure(EntityTypeBuilder<WeightsTracking> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.user_id).IsRequired();
            builder.Property(x => x.day).IsRequired();
            builder.Property(x => x.kilo).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.WeightsTrackings)
                .HasForeignKey(x => x.user_id);
        }
    }
}
