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

        public async Task<IEnumerable<Place>> FiltarAll_Internet()
        {
            return await _destinationDbContext.Place.ToListAsync();
        }

        public Task<IQueryable<Country>> Filter(Expression<Func<Country, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Country>> FilterAll()
        {
            return await _destinationDbContext.Country
                .Include(x => x.Cities)
                .ThenInclude(x => x.NearActivities)
                .Include(x => x.Cities)
                .ThenInclude(x => x.Places)
                .ToListAsync();
            
           
        }

        public async Task<IEnumerable<Activity>> FilterAll_Activities()
        {
            return await _destinationDbContext.Activity
                .ToListAsync();
        }

        public async Task<IEnumerable<Country>> FilterBy(Expression<Func<Country, bool>> predicate)
        {
            return await _destinationDbContext.Set<Country>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<Country>> Filterby(FilterMaster search)
        {
            var data = await (from country in _destinationDbContext.Country
                              from city in country.Cities
                              from place in city.Places
                              where place.AvailableFrom == search.date || place.AvailableTo == search.date2 ||
                                    place.PriceNight == search.price || place.WifiQuality == search.internet
                              select country)
                            .Include(x => x.Cities)
                            .ThenInclude(x => x.NearActivities)
                            .Include(x => x.Cities)
                            .ThenInclude(x => x.Places)
                            .ToListAsync();

            return data;

        }
    }
}


