using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        public EpaycoSdk.Epayco epayco = new EpaycoSdk.Epayco(
            "c3730256d895667d8aafc6d8778973e1", //String PublicKey
            "eaf63f9490370b9eb71818ea17f510cb", //String Private Key
            "ES", //String lang
             true //Boolean TestMode
           );
    }
}
