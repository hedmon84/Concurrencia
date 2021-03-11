using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Entities
{
    public class Place :BaseEntity
    {

      

        public string TypeBuilding { get; set; }

        public string Address { get; set; }

        public int WifiQuality { get; set; }

        public float PriceNight { get; set; }

        public string AvailableFrom { get; set; }
        public string AvailableTo { get; set; }

        public int CityId { get; set; }

     //   public City City { get; set; }
    }
}
