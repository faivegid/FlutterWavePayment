using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlutterWave.Models
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string name, string email, string phoneNumber) : this()
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
    }
}
