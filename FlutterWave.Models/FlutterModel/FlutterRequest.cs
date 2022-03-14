using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlutterWave.Models
{
    public class FlutterRequest
    {
        public string tx_Ref { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string redirect_Url { get; set; }
        public string meta { get; set; }
        public string customizaitons { get; set; }
        public string subAccounts { get; set; }
        public string payment_plan { get; set; }
        public string payment_options { get; set; }
        public Customer customer { get; set; }
    }
}
