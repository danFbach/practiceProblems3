using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class SportsCar : Vehicles
    {
        public SportsCar(int price)
        {
            this.price = price;
            this.type = "Sports Car";
        }
    }
}
