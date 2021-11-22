using EpaycoSdk.Models;
using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : HomeController
    {

        [HttpPost]
        public TokenModel Post([FromBody] Models.Card card)
        {
            TokenModel token = epayco.CreateToken(
                card.cardNumber,
                card.expYear,
                card.expMonth,
                card.cvc
           );

            return token;
        }

    }
}
