using EpaycoSdk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : HomeController
    {

        [HttpPost]
        public TokenModel Post([FromBody] Models.Card card)
        {
            var headers = Request.Headers;
            string apikey = "";
            string privatekey = "";
            bool test = true;
            StringValues values;
            if (headers.ContainsKey("apikey"))
            {
                headers.TryGetValue("apikey", out values);
                apikey = values.FirstOrDefault();
            }

            if (headers.ContainsKey("privatekey"))
            {
                headers.TryGetValue("privatekey", out values);
                privatekey = values.FirstOrDefault();
            }

            if (headers.ContainsKey("test"))
            {
                headers.TryGetValue("test", out values);
                test = Convert.ToBoolean(values.FirstOrDefault());
            }

            EpaycoSdk.Epayco epayco = InitSDK(apikey, privatekey, test);
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
