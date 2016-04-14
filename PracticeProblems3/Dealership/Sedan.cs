using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class Sedan : Vehicle
    {
        public Sedan(int price)
        {
            this.price = price;
            this.type = "sedan";
        }
    }
}
