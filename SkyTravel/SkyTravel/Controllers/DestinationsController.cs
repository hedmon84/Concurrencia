using Microsoft.AspNetCore.Mvc;
using SkyTravel.Api.Models;
using SkyTravel.Core.Entities;
using SkyTravel.Core.Enum;
using SkyTravel.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyTravel.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DestinationsController : Controller
    {

        private readonly IDestinationService _destinationService;

        public DestinationsController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryDto>>> Get()
        {
            var serviceResult = await _destinationService.FilterAll();
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);



            return Ok(serviceResult.Result.Select(x => new CountryDto
            {
                Name = x.Name,
                Cities = x.Cities.Select(y => new CityDto
                {
                    Name = y.Name,
                    Places = y.Places.Select(z => new PlaceDto
                    {
                        
                        Address = z.Address,
                        AvailableFrom = z.AvailableFrom,
                        AvailableTo = z.AvailableTo,
                        PriceNight = z.PriceNight,
                        TypeBuilding = z.TypeBuilding,
                        WifiQuality = z.WifiQuality,

                    }).ToList(),
                    NearActivities = y.NearActivities.Select(w => new ActivityDto
                    {
                        Name = w.Name,
                    }).ToList(),
                }).ToList()


            }


             ));
        }

        //[HttpGet]
        //[Route("{place}/{date}/{date2}/{price}/{internet}")]
        //public ActionResult<IEnumerable<Country>> Getby(string place, string date, string date2, float price, int internet)
        //{
        //    var serviceResult = _destinationService.FilterByOptions(place, date, date2,price,internet);
        //    if (serviceResult.ResponseCode != ResponseCode.Success)
        //        return BadRequest(serviceResult.Error);
        //    return Ok(serviceResult.Result);
        //}
    }
}
