using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<Country>>> Get()
        {
            var serviceResult = await _destinationService.FilterAll();
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);
           
            
          
            return Ok(serviceResult.Result.Select( x => new CountryDto
            {
               Name = x.Name,
               Cities = x.Cities,


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
