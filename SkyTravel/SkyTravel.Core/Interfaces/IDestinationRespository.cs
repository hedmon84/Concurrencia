using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SkyTravel.Core.Interfaces
{
    public interface IDestinationRespository
    {
        Task<IEnumerable<Country>> FilterAll();
        Task<IEnumerable<Activity>> FilterAll_Activities();
        Task<IEnumerable<Place>> FiltarAll_Internet();

        Task <IEnumerable<Country>> Filterby(FilterMaster search);
   
    }
}
