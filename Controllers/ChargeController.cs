using EpaycoSdk.Models.Charge;
using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargeController : HomeController
    {

        [HttpGet("{ref_payco}")]
        public ChargeTransactionModel Get(string ref_payco)
        {
            ChargeTransactionModel cash = epayco.GetChargeTransaction(ref_payco);
            return cash;

        }

        [HttpPost]
        public ChargeModel Post([FromBody] Models.Charge body)
        {
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
