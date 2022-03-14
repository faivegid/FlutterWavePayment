using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlutterWave.Models.ViewModels
{
    public class PaymentViewModel
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
