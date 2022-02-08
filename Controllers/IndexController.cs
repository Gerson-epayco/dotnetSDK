using Microsoft.AspNetCore.Mvc;


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
