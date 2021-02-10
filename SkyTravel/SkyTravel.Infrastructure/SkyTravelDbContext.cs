using Microsoft.EntityFrameworkCore;
using SkyTravel.Core.Entities;
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

        public DbSet<Destination> Destionations { get; set; }
    }
}
