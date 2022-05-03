using EpaycoSdk.Models.Safetypay;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SafetypayController : HomeController
    {
        [HttpPost]
        public safetypayModel Post([FromBody] Models.Safetypay body)
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
            safetypayModel response = epayco.SafetypayCreate(
                body.cash,
                body.end_date,
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
                body.test,
                body.url_response,
                body.url_confirmation,
                body.url_response_pointer,
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
    }
}
