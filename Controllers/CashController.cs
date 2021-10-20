using EpaycoSdk.Models.Cash;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashController : HomeController
    {
        [HttpGet("{ref_payco}")]
        public CashTransactionModel Get(string ref_payco)
        {
            CashTransactionModel cash = epayco.GetCashTransaction(ref_payco);
            return cash;
        }

        [HttpPost]
        public CashModel Post([FromBody] Models.Cash body)
        {
            string splitData = JsonConvert.SerializeObject(body.split_details);
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
                splitData
            );
            return response;
        }
    }
}
