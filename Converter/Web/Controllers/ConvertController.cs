using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public IActionResult Get(double value, int fromUnitId, int toUnitId)
        {
            return Ok(1.1);
        }
    }
}
