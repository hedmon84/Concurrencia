using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyTravel.Api.Models
{
    public class CityDto 
    {

        public CityDto()
        {
            NearActivities = new List<Activity>();
            Places = new List<Place>();
        }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public ICollection<Activity> NearActivities { get; set; }

        public ICollection<Place> Places { get; set; }

    }
}
