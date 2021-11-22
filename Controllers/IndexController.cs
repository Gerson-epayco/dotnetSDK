using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epaycoTest.Controllers
{
    [Route("")]
    [ApiController]
    public class IndexController : ControllerBase
    {

        [HttpGet]
        public string Index()
        {
            return "API to test Epayco SDK-.NET";
        }
    }
}
