using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Infrastructure.Configurations
{
    class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(gg => gg.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).IsRequired();


           // builder.HasMany<Activity>(x => x.NearActivities)
           //     .WithOne(x => x.City)
           //    .HasForeignKey(x => x.CityId);

           // builder.HasMany<Place>(x => x.Places)
           // .WithOne(x => x.City)
           //.HasForeignKey(x => x.CityId);


                         
        }
    }
}
