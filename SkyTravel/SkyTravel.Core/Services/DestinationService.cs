using SkyTravel.Core.Entities;
using SkyTravel.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Services
{
    public class DestinationService : IDestinationService
    {

        private readonly IDestinationRespository<Country> _destinationService;

        public DestinationService(IDestinationRespository<Country> destinationService)
        {
            _destinationService = destinationService;
        }

        public ServiceResult<IEnumerable<Country>> FilterByOptions(string place, string date,string date2, float price, int internet)
        {
            Place tmpPlace = new Place();
            tmpPlace.AvailableFrom = date;
            tmpPlace.AvailableTo = date2;
            tmpPlace.PriceNight = price;
            City tmpcity = new City();
            tmpcity.Name = place;
            tmpcity.Places.Contains(tmpPlace);
           
            return ServiceResult<IEnumerable<Country>>.SuccessResult(_destinationService.FilterBy(x=> x.Cities.Contains(tmpcity)));
        }

        ServiceResult<IEnumerable<Country>> IDestinationService.FilterAll()
        {
            return ServiceResult<IEnumerable<Country>>.SuccessResult(_destinationService.FilterAll());
        }
    }
}
