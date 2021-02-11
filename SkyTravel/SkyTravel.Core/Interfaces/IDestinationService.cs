using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyTravel.Core.Interfaces
{
    public interface IDestinationService
    {

        ServiceResult<IEnumerable<Country>> FilterAll();
    }
}
