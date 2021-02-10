using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Infrastructure.Configurations
{
    public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.LuxuryQuality).IsRequired();
            builder.Property(x => x.WiFiQuality).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.AvalaibleDates).IsRequired();
            builder.Property(x => x.NearByActivities).IsRequired();
            builder.Property(x => x.PriceByNight).IsRequired();
            builder.Property(x => x.TypeofBuilding).IsRequired();
        }
    }
}
