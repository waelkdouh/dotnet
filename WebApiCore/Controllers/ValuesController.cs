using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetStandardLib;
//using Net4._7._2Lib;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            UtilityHelper helper = new UtilityHelper();
            //UtilityHelperNet472 helpertwo = new UtilityHelperNet472();

            return new string[] { "value1", "value2", helper.Calculate(3, 3).ToString(), helper.CreateOneTwoThree().First().ToString(), RuntimeInformation.OSDescription };
            //return new string[] { "value1", "value2", helpertwo.Calculate(3, 3).ToString(), RuntimeInformation.OSDescription };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
