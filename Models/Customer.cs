using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epaycoTest.Models
{
    public class Card
    {
        public string cardNumber { get; set; }
        public string expYear { get; set; }
        public string expMonth { get; set; }
        public string cvc { get; set; }
    }

    public class Customer
    {
        public string token_card { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public bool is_default { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string cell_phone { get; set; }
    }

    public class CustomerDeleteToken
    {
        public string franchise { get; set; }
        public string mask { get; set; }
        public string customer_id { get; set; }
    }

    public class defaultToken
    {
        public string franchise { get; set; }
        public string token { get; set; }
        public string mask { get; set; }
        public string customer_id { get; set; }
    }

    public class newTokenCard
    {
        public string token_card { get; set; }
        public string customer_id { get; set; }
    }
}
