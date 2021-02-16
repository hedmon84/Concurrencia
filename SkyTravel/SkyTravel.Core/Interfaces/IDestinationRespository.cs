using SkyTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SkyTravel.Core.Interfaces
{
    public interface IDestinationRespository<T>
    {
        IEnumerable<T> FilterAll();
        IEnumerable<T> FilterBy(Expression<Func<Country, bool>> predicate);
    }
}
