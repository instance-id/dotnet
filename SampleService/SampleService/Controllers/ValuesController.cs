using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleService.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new[] { "Operation:", "Successful" };
        }
    }
}
