using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Entities
{
    public class Place :BaseEntity
    {

      

        public string TypeBuilding { get; set; }

        public string Addres { get; set; }

        public int WifiQuality { get; set; }

        public float PriceNight { get; set; }

        public string AvailableDates { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}
