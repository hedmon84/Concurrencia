using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Entities
{
    public class Country : BaseEntity
    {
        public Country()
        {
            Cities = new List<City>();
        }


        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
