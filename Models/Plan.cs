namespace epaycoTest.Models
{
    public class Plan
    {
        public string id_plan { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string interval { get; set; }
        public int interval_count { get; set; }
        public int trial_days { get; set; }
    }
}
