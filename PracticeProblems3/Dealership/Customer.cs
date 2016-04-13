using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class Customer
    {
        public string firstName;
        public string lastName;
        public int customerID;
        public string carTypePurchased;
        public int purchasePrice;
        public Customer(string firstName, string lastName, int customerID, string carTypePurchased, int purchasePrice)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.customerID = customerID;
            this.carTypePurchased = carTypePurchased;
            this.purchasePrice = purchasePrice;
        }
    }
}
