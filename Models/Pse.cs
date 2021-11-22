using EpaycoSdk.Models.Bank;
using System.Collections.Generic;
namespace epaycoTest.Models
{
    public class Pse
    {
        public string bank_code { get; set; }
        public string invoice { get; set; }
        public string description { get; set; }
        public string value { get; set; }
        public string tax { get; set; }
        public string tax_base { get; set; }
        public string ico { get; set; }
        public string currency { get; set; }
        public string type_person { get; set; }
        public string doc_type { get; set; }
        public string doc_number { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string country { get; set; }
        public string cell_phone { get; set; }
        public string url_response { get; set; }
        public string url_confirmation { get; set; }
        public string method_confirmation { get; set; }
        public string extra1 { get; set; }
        public string extra2 { get; set; }
        public string extra3 { get; set; }
        public string extra4 { get; set; }
        public string extra5 { get; set; }
        public string extra6 { get; set; }
        public string extra7 { get; set; }
    }

    public class PseSplit
    {
        public string bank_code { get; set; }
        public string invoice { get; set; }
        public string description { get; set; }
        public string value { get; set; }
        public string tax { get; set; }
        public string tax_base { get; set; }
        public string ico { get; set; }
        public string currency { get; set; }
        public string type_person { get; set; }
        public string doc_type { get; set; }
        public string doc_number { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string country { get; set; }
        public string cell_phone { get; set; }
        public string url_response { get; set; }
        public string url_confirmation { get; set; }
        public string method_confirmation { get; set; }
        public string splitpayment { get; set; }
        public string split_app_id { get; set; }
        public string split_merchant_id { get; set; }
        public string split_type { get; set; }
        public string split_rule { get; set; }
        public string split_primary_receiver { get; set; }
        public string split_primary_receiver_fee { get; set; }
        public List<SplitReceivers> split_receivers { get; set; }
        public string extra1 { get; set; }
        public string extra2 { get; set; }
        public string extra3 { get; set; }
        public string extra4 { get; set; }
        public string extra5 { get; set; }
        public string extra6 { get; set; }
        public string extra7 { get; set; }
    }
}
