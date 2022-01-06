using EpaycoSdk.Models.Daviplata;
using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaviplataController : HomeController
    {
    
        [HttpPost]
        public DaviplataModel Post([FromBody] Models.Daviplata body)
        {
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
            DaviplataConfirmModel response = epayco.daviplataConfirm(
                body.ref_payco,
                body.id_session_token,
                body.otp
            );
            return response;
        }
    }
}
