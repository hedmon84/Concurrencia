using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Infrastructure.Configurations
{
    class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasKey(gg => gg.Id);

            builder.Property(gg => gg.Id).ValueGeneratedOnAdd();

            builder.Property(gg => gg.Addres).IsRequired();


            builder.Property(gg => gg.TypeBuilding).IsRequired();

            builder.Property(gg => gg.WifiQuality).IsRequired();

            builder.Property(gg => gg.AvailableDates).IsRequired();
            


        }
    }
}
