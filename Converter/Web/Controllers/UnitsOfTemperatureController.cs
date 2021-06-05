using Microsoft.AspNetCore.Mvc;
using Services.UnitsOfTemperature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsOfTemperatureController : ControllerBase
    {
        private readonly IUnitsOfTemperatureService unitsOfTemperatureService;

        public UnitsOfTemperatureController(IUnitsOfTemperatureService unitsOfTemperatureService)
        {
            this.unitsOfTemperatureService = unitsOfTemperatureService;
        }

        // GET: api/<UnitsOfTemperatureController>
        [HttpGet]
        public IActionResult Get()
        {
            var models = unitsOfTemperatureService.GetUnitsOfTemperature();
            return Ok(models);
        }

        // GET api/<UnitsOfTemperatureController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = unitsOfTemperatureService.GetUnitOfTemperature(id);
                return Ok(model);
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
        }
    }
}
