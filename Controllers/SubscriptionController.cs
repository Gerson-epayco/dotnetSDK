using EpaycoSdk.Models.Subscriptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : HomeController
    {
        [HttpGet]
        public AllSubscriptionModel Get()
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
            AllSubscriptionModel subscription = epayco.getAllSubscription();
            return subscription;

        }

        [HttpGet("{subscription_id}")]
        public FindSusbscriptionModel Get(string subscription_id)
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
            FindSusbscriptionModel subscription = epayco.getSubscription(subscription_id);
            return subscription;

        }

        [HttpPost("/pay")]
        public ChargeSubscriptionModel Post([FromBody] Models.SuscriptionPay body)
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
            CancelSubscriptionModel subscription = epayco.cancelSubscription(subscription_id);
            return subscription;
        }
    }
}
