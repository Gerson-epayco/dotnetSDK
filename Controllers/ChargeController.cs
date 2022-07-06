using EpaycoSdk.Models.Charge;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargeController : HomeController
    {

        [HttpGet("{ref_payco}")]
        public ChargeTransactionModel Get(string ref_payco)
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
            ChargeTransactionModel cash = epayco.GetChargeTransaction(ref_payco);
            return cash;

        }

        [HttpPost]
        public ChargeModel Post([FromBody] Models.Charge body)
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
            
            EpaycoSdk.Epayco epayco = InitSDK(apikey, privatekey, false);
            ChargeModel response = epayco.ChargeCreate(
                body.token_card,
                body.customer_id,
                body.doc_type,
                body.doc_number,
                body.name,
                body.last_name,
                body.email,
                body.bill,
                body.description,
                body.value,
                body.tax,
                body.tax_base,
                body.ico,
                body.currency,
                body.dues,
                body.address,
                body.country,
                body.city,
                body.phone,
                body.cell_phone,
                body.url_response,
                body.url_confirmation,
                body.method_confirmation,
                body.ip,
                body.extra1,
                body.extra2,
                body.extra3,
                body.extra4,
                body.extra5,
                body.extra6,
                body.extra7,
                body.extra8,
                body.extra9,
                body.extra10,
                body.split_details
            );
            return response;
        }
    }
}
