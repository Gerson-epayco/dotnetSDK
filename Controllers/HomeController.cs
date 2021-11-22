using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        public EpaycoSdk.Epayco epayco = new EpaycoSdk.Epayco(
            "32c8ef12cc65878db1ccff30cdaf8e49", //String PublicKey
            "d84e9885d4f7de545e09736e9c5beb61", //String Private Key
            "ES", //String lang
             false //Boolean TestMode
           );
    }
}
