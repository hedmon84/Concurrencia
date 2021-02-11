using Microsoft.EntityFrameworkCore;
using SkyTravel.Core.Entities;
using SkyTravel.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Infrastructure
{
    public class SkyTravelDbContext : DbContext
    {
        public SkyTravelDbContext(DbContextOptions options) :
                base(options)
        {        
        }

       

        public DbSet<Activity> Activity { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<Place> Place { get; set; }

        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new PlaceConfiguration());
        }
    }
}
