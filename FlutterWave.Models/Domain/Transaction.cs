using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlutterWave.Models.Domain
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId  { get; set; }
        public Customer Customer { get; set; }
    }
}
