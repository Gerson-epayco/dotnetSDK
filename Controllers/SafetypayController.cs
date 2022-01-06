using EpaycoSdk.Models.Safetypay;
using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SafetypayController : HomeController
    {
        [HttpPost]
        public safetypayModel Post([FromBody] Models.Safetypay body)
        {
           safetypayModel response = epayco.safetypayCreate(
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
                body.method_confirmation
            );

            return response;
        }
    }
}
