using SkyTravel.Core.Entities;
using SkyTravel.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkyTravel.Core.Services
{
    public class DestinationService : IDestinationService
    {

        private readonly IDestinationRespository _destinationService;

        public DestinationService(IDestinationRespository destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<ServiceResult<IEnumerable<Country>>> FilterByOptions(string place, string date,string date2, float price, int internet)
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

        public async Task<ServiceResult<IEnumerable<Country>>> FilterAll()
        {
            var result = await _destinationService.FilterAll();
            return ServiceResult<IEnumerable<Country>>.SuccessResult(result);
        }
    }
}
