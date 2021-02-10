using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TravelAgency.Core.Entities;
using TravelAgency.Infrastructure.Configurations;

namespace TravelAgency.Infrastructure
{
    public class TravelAgencyDbContext : DbContext
    {
        public TravelAgencyDbContext(DbContextOptions options) :
             base(options)
        {

        }

        public DbSet<Destination> Destinations { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TravelAgencyConfiguration());
        }
        */
    }
}
