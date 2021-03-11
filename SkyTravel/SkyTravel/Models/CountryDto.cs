using SkyTravel.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Entities
{
    public class CountryDto
    {
        public CountryDto()
        {
            Cities = new List<CityDto>();
        }

        public string Name { get; set; }

        public ICollection<CityDto> Cities { get; set; }
    }
}
