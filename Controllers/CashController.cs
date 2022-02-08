using EpaycoSdk.Models.Cash;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashController : HomeController
    {
        [HttpGet("{ref_payco}")]
        public CashTransactionModel Get(string ref_payco)
        {
            var headers = Request.Headers;
            string apikey = "";
            string privatekey = "";
            bool test = true;
            StringValues values;
            if (headers.ContainsKey("apikey"))
            {
                headers.TryGetValue("apikey",out values);
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
            CashTransactionModel cash = epayco.GetCashTransaction(ref_payco);
            return cash;
        }

        [HttpPost]
        public CashModel Post([FromBody] Models.Cash body)
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
            CashModel response = epayco.CashCreate(
                body.type,
                body.invoice,
                body.description,
                body.value,
                body.tax,
                body.tax_base,
                body.ico,
                body.currency,
                body.type_person,
                body.doc_type,
                body.doc_number,
                body.name,
                body.last_name,
                body.email,
                body.cell_phone,
                body.end_date,
                body.url_response,
                body.url_confirmation,
                body.method_confirmation,
                body.split_details);
            return response;
        }
    }
}
