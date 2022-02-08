using EpaycoSdk.Models.Bank;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace epaycoTest.Controllers
{
    [Route("api/bank")]
    [ApiController]
    public class PseController : HomeController
    {
        [HttpGet]
        public BanksModel Get()
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
            BanksModel banks = epayco.GetBanks();
            return banks;
        }

        [HttpGet("{ticketId}")]
        public TransactionModel Get(string ticketId)
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
            TransactionModel transaction = epayco.GetTransaction(ticketId);
            return transaction;
        }

        [HttpPost]
        public PseModel Post([FromBody] Models.Pse body)
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
            PseModel response = epayco.BankCreate(
              body.bank_code,
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
              body.country,
              body.cell_phone,
              body.url_response,
              body.url_confirmation,
              body.method_confirmation,
              body.extra1 = "",
              body.extra2 = "",
              body.extra3 = "",
              body.extra4 = "",
              body.extra5 = "",
              body.extra6 = "",
              body.extra7 = ""
            );
            return response;
        }

        [Route("splitpayment")]
        [HttpPost]
        public PseModel Post([FromBody] Models.PseSplit body)
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
            PseModel response = epayco.BankCreateSplit(
              body.bank_code,
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
              body.country,
              body.cell_phone,
              body.url_response,
              body.url_confirmation,
              body.method_confirmation,
              body.splitpayment,
              body.split_app_id,
              body.split_merchant_id,
              body.split_type,
              body.split_rule,
              body.split_primary_receiver,
              body.split_primary_receiver_fee,
              body.split_receivers,
              body.extra1 = "",
              body.extra2 = "",
              body.extra3 = "",
              body.extra4 = "",
              body.extra5 = "",
              body.extra6 = "",
              body.extra7 = ""
            );
            return response;
        }
    }
}
