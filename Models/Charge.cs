using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpaycoSdk.Models.Bank;

namespace epaycoTest.Models
{
    public class Charge
    {
        public string token_card { get; set; }
        public string customer_id { get; set; }
        public string doc_type { get; set; }
        public string doc_number { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string bill { get; set; }
        public string description { get; set; }
        public string value { get; set; }
        public string tax { get; set; }
        public string tax_base { get; set; }
        public string ico { get; set; }
        public string currency { get; set; }
        public string dues { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string cell_phone { get; set; }
        public string url_response { get; set; }
        public string url_confirmation { get; set; }
        public string method_confirmation { get; set; }
        public string ip { get; set; }
        public string extra1 { get; set; }
        public string extra2 { get; set; }
        public string extra3 { get; set; }
        public string extra4 { get; set; }
        public string extra5 { get; set; }
        public string extra6 { get; set; }
        public string extra7 { get; set; }
        public string extra8 { get; set; }
        public string extra9 { get; set; }
        public string extra10 { get; set; }
        public SplitModel split_details { get; set; }
}
}
