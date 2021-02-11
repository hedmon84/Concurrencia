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

        ServiceResult<IEnumerable<Country>> IDestinationService.FilterAll()
        {
            return ServiceResult<IEnumerable<Country>>.SuccessResult(_destinationService.FilterAll());
        }
    }
}
