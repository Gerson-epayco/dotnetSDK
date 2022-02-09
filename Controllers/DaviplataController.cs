using EpaycoSdk.Models.Daviplata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaviplataController : HomeController
    {
    
        [HttpPost]
        public DaviplataModel Post([FromBody] Models.Daviplata body)
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

            Console.Write("va a inizialisar el sdk con writeLine " + apikey + ":" + privatekey + " " + test);

            EpaycoSdk.Epayco epayco = InitSDK(apikey, privatekey, test);
            DaviplataModel response = epayco.daviplataCreate(
                body.doc_type,
                body.document,
                body.name,
                body.last_name,
                body.email,
                body.ind_country,
                body.phone,
                body.country,
                body.city,
                body.address,
                body.ip,
                body.currency,
                body.invoice,
                body.description,
                body.value,
                body.tax, 
                body.tax_base,
                body.ico,
                body.test = false,
                body.url_response,
                body.url_confirmation,
                body.method_confirmation
            );
            return response;
        }

        [HttpPost("confirm")]
        public DaviplataConfirmModel Post([FromBody] Models.DaviplataConfirm body)
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
            DaviplataConfirmModel response = epayco.daviplataConfirm(
                body.ref_payco,
                body.id_session_token,
                body.otp
            );
            return response;
        }
    }
}
