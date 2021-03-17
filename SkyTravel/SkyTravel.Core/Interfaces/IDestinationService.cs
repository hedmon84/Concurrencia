using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkyTravel.Core.Interfaces
{
    public interface IDestinationService
    {

        Task<ServiceResult<IEnumerable<Country>>> FilterAll();
        Task<ServiceResult<IEnumerable<Activity>>> FilterAcivities();
        Task<ServiceResult<IEnumerable<Place>>> FilterInternet();
        Task<ServiceResult<IEnumerable<Country>>> FilterByOptions(FilterMaster search);
    }
}
