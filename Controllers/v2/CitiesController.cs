using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CitiesManager.Web.DatabaseContext;
using CitiesManager.Web.Models;
using Asp.Versioning;

namespace CitiesManager.Web.Controllers.v2

{
    [ApiVersion("2.0")]
    public class CitiesController : CustomControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// To Get Cities all the cities
        /// </summary>
        /// <returns></returns>
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string?>>> GetCities()
        {
            var cities = await _context.Cities
                .OrderBy(temp => temp.CityName)
                .Select(temp => temp.CityName)
                .ToListAsync();

            return cities;
        }

    }
}
