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
            NearActivities = new List<ActivityDto>();
            Places = new List<PlaceDto>();
        }

        public string Name { get; set; }

        public ICollection<ActivityDto> NearActivities { get; set; }

        public ICollection<PlaceDto> Places { get; set; }

    }
}
