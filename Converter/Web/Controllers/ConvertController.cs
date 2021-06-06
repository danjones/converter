using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.UnitsOfTemperature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertController : ControllerBase
    {
        private readonly IUnitsOfTemperatureService unitsOfTemperatureService;

        public ConvertController(IUnitsOfTemperatureService unitsOfTemperatureService)
        {
            this.unitsOfTemperatureService = unitsOfTemperatureService;
        }

        [HttpGet]
        public IActionResult Get(double value, int fromUnitId, int toUnitId)
        {
            try
            {
                var result = unitsOfTemperatureService.Convert(value, fromUnitId, toUnitId);
                return Ok(result);
            }
            catch(InvalidOperationException)
            {
                return NotFound();
            }
        }
    }
}
