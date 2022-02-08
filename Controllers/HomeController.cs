using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    public class HomeController : ControllerBase
    {
        public EpaycoSdk.Epayco InitSDK (string apikey, string privateKey, bool test = true)
        {
           return  new EpaycoSdk.Epayco(apikey,  privateKey,  "ES",  test );
        }
    }
}
