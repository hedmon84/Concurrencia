using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Entities
{
    public class City : BaseEntity
    {
        public City()
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
