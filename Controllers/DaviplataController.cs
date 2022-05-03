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
            DaviplataModel response = epayco.DaviplataCreate(
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
                body.method_confirmation,
                body.extra1,
                body.extra2,
                body.extra3,
                body.extra4,
                body.extra5,
                body.extra6,
                body.extra7,
                body.extra8,
                body.extra9,
                body.extra10
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
            DaviplataConfirmModel response = epayco.DaviplataConfirm(
                body.ref_payco,
                body.id_session_token,
                body.otp
            );
            return response;
        }
    }
}
