using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNum.API.Controllers
{
    [ApiController]
    public class SumNumController : ControllerBase
    {
        private readonly ISumTwoNums _sumTwoNums;

        public SumNumController(ISumTwoNums sumTwoNums)
        {
            _sumTwoNums = sumTwoNums;
        }

        [HttpGet]
        [Route("[controller]")]
        public ActionResult<int> Get([FromQuery] int a, [FromQuery] int b)
        {
            return Ok(_sumTwoNums.Sum(a, b));
        }
    }
}
