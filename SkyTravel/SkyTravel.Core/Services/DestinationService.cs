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

        public async Task<ServiceResult<IEnumerable<Country>>> FilterByOptions(FilterMaster search)
        {

            var result = await _destinationService.Filterby(search);


            return ServiceResult<IEnumerable<Country>>.SuccessResult(result);
        }

        public async Task<ServiceResult<IEnumerable<Country>>> FilterAll()
        {
            var result = await _destinationService.FilterAll();
            return ServiceResult<IEnumerable<Country>>.SuccessResult(result);
        }

        public async Task<ServiceResult<IEnumerable<Activity>>> FilterAcivities()
        {
            var result = await _destinationService.FilterAll_Activities();
            return ServiceResult<IEnumerable<Activity>>.SuccessResult(result);
        }

        public async Task<ServiceResult<IEnumerable<Place>>> FilterInternet()
        {
            var result = await _destinationService.FiltarAll_Internet();
            return ServiceResult<IEnumerable<Place>>.SuccessResult(result);
        }
    }
}
