using EpaycoSdk.Models.Subscriptions;
using Microsoft.AspNetCore.Mvc;


namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : HomeController
    {
        [HttpGet]
        public AllSubscriptionModel Get()
        {
            AllSubscriptionModel subscription = epayco.getAllSubscription();
            return subscription;

        }

        [HttpGet("{subscription_id}")]
        public FindSusbscriptionModel Get(string subscription_id)
        {
            FindSusbscriptionModel subscription = epayco.getSubscription(subscription_id);
            return subscription;

        }

        [HttpPost("/pay")]
        public ChargeSubscriptionModel Put([FromBody] Models.SuscriptionPay body)
        {
            ChargeSubscriptionModel subscription = epayco.ChargeSubscription(
                body.id_plan,
                body.customer_id,
                body.token_card,
                body.doc_type,
                body.doc_number,
                body.ip,
                body.address,
                body.phone,
                body.cell_phone
            );
            return subscription;
        }

        [HttpPost]
        public CreateSubscriptionModel Post([FromBody] Models.Suscription body)
        {
            CreateSubscriptionModel subscription = epayco.SubscriptionCreate(
                body.id_plan,
                body.customer_id,
                body.token_card,
                body.doc_type,
                body.doc_number,
                body.url_confirmation,
                body.method_confirmation
            );
            return subscription;

        }

        [HttpDelete("{subscription_id}")]
        public CancelSubscriptionModel Delete(string subscription_id)
        {
            CancelSubscriptionModel subscription = epayco.cancelSubscription(subscription_id);
            return subscription;
        }
    }
}
