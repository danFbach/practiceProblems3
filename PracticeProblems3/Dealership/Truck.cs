using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class Truck : Vehicle
    {
        public Truck(int price)
        {
            this.price = price;
            this.type = "truck";
        }
    }
}
