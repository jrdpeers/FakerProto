using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerProto
{
    public class Customer : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string BS { get; set; }

        public Customer() { }

        public Customer(string firstName, string lastName, string company)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
        }
    }
}
