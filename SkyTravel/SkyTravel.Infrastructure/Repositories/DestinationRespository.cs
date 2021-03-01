using Microsoft.EntityFrameworkCore;
using SkyTravel.Core;
using SkyTravel.Core.Entities;
using SkyTravel.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SkyTravel.Infrastructure.Repositories
{
    public class DestinationRespository : IDestinationRespository
    {


        private readonly SkyTravelDbContext _destinationDbContext;

        public DestinationRespository(SkyTravelDbContext destinationDbContext )
        {
            _destinationDbContext = destinationDbContext;
        }
       

       public async Task<IEnumerable<Country>> FilterAll()
        {
            return await _destinationDbContext.Country.Include(x => x.Cities).ThenInclude(x => x.NearActivities).ToListAsync();
            
           
        }

        public IEnumerable<Country> FilterBy(Expression<Func<Country, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
