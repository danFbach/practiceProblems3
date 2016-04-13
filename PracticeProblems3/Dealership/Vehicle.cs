using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class Vehicle
    {
        public int price;
        public string type;
        public Vehicle()
        {
        }
        public override string ToString()
        {
            return String.Format("Type of vehicle: {0}   |   Price: {1}", type, price.ToString("C2"));
        }

    }
}
