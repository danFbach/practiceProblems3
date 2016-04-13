using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class Customer
    {
        public string name;
        public int customerID;
        public string carPreference;
        public Customer(string name, int customerID, string carPreference)
        {
            this.name = name;
            this.customerID = customerID;
            this.carPreference = carPreference;
        }
    }
}
