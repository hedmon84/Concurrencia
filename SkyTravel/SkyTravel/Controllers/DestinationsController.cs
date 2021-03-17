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



        //experience

        [HttpGet]
        [Route("Experience")]
        public async Task<ActionResult<IEnumerable<ActivityDto>>> Getby()
        {
            var serviceResult = await _destinationService.FilterAcivities();

            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            return Ok(serviceResult.Result.Select(x => new ActivityDto
            {

                Name = x.Name


            }).ToList()); 



        }

        //Internet

        [HttpGet]
        [Route("Internet")]
        public async Task<ActionResult<IEnumerable<InternetDto>>> GetInternet()
        {
            var serviceResult = await _destinationService.FilterInternet();

            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            return Ok(serviceResult.Result.Select(x => new InternetDto
            {

                WifiQuality = x.WifiQuality


            }).ToList());



        }




        //Internet
        [HttpGet]
        [Route("search")]
        public async Task<ActionResult<IEnumerable<CountryDto>>> GetS( [FromBody] FilterMaster search)
        {
            var serviceResult = await _destinationService.FilterByOptions(search);
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);
            return Ok(serviceResult.Result);
        }
    }
}
