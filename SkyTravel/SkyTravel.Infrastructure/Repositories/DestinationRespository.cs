using Microsoft.EntityFrameworkCore;
using SkyTravel.Core;
using SkyTravel.Core.Entities;
using SkyTravel.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SkyTravel.Infrastructure.Repositories
{
    public class DestinationRespository<T> : IDestinationRespository<T> where T : BaseEntity
    {


        private readonly SkyTravelDbContext _destinationDbContext;

        public DestinationRespository(SkyTravelDbContext destinationDbContext )
        {
            _destinationDbContext = destinationDbContext;
        }
       

        IEnumerable<T> IDestinationRespository<T>.FilterAll()
        {

            return (IEnumerable<T>)_destinationDbContext.Country.Include(x => x.Cities);
        }
    }
}
