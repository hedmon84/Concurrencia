using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Interfaces
{
    public interface IDestinationService
    {

        ServiceResult<IEnumerable<Country>> FilterAll();
        ServiceResult<IEnumerable<Country>> FilterByOptions(string place, string date, string date2, float price, int internet);
    }
}
