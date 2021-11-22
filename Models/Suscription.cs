namespace epaycoTest.Models
{
    public class Suscription
    {
        public string id_plan { get; set; }
        public string customer_id { get; set; }
        public string token_card { get; set; }
        public string doc_type { get; set; }
        public string doc_number { get; set; }
        public string url_confirmation { get; set; }
        public string method_confirmation { get; set; }
    }

    public class SuscriptionPay
    {
        public string id_plan { get; set; }
        public string customer_id { get; set; }
        public string token_card { get; set; }
        public string doc_type { get; set; }
        public string doc_number { get; set; }
        public string ip { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string cell_phone { get; set; }
    }
}
