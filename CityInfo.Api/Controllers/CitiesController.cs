using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            // check if city exists
            var cityExists = CitiesDataStore.Current.Cities.FirstOrDefault(city => city.Id == id);

            if(cityExists == null)
            {
                return NotFound();
            }

            return Ok(cityExists);
        }
    }
}
