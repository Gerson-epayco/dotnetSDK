using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epaycoTest.Models
{
    public class Safetypay
    {
        public Safetypay() {
            extra1 = "";
            extra2 = "";
            extra3 = "";
            extra4 = "";
            extra5 = "";
            extra6 = "";
            extra7 = "";
            extra8 = "";
            extra9 = "";
            extra10 = "";
        }

        public string cash { get; set; }
        public string end_date { get; set; }
        public string doc_type { get; set; }
        public string document { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string ind_country { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string ip { get; set; }
        public string currency { get; set; }
        public string invoice { get; set; }
        public string description { get; set; }
        public decimal value { get; set; }
        public decimal tax { get; set; }
        public decimal tax_base { get; set; }
        public decimal ico { get; set; }
        public bool test { get; set; }
        public string url_response { get; set; }
        public string url_confirmation { get; set; }
        public string url_response_pointer { get; set; }
        public string method_confirmation { get; set; }
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
    }
}
