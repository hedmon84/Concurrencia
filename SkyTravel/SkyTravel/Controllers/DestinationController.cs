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
    public class DestinationController : Controller
    {

        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }


        [HttpGet]
        [Route("list")]
        public ActionResult<IEnumerable<Country>> Get()
        {
            var serviceResult = _destinationService.FilterAll();
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);
            return Ok(serviceResult.Result);
        }
    }
}
