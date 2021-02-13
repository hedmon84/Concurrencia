using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Entities
{
    public class Activity : BaseEntity
    {

        public string Name { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}
