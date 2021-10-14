using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        public EpaycoSdk.Epayco epayco = new EpaycoSdk.Epayco(
            "32e4e653daf732e428560c3b76743a85", //String PublicKey
            "0950b3575b9607f22e7851db37699a8b", //String Private Key
            "ES", //String lang
             false //Boolean TestMode
           );
    }
}
