using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumNum.BusinessLogic;

namespace SumNum.API.Controllers
{
    [ApiController]
    public class SumNumController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]")]
        public ActionResult<int> Get([FromQuery] int a, [FromQuery] int b)
        {
            return Ok(SumClass.Sum(a, b));
        }
    }
}
