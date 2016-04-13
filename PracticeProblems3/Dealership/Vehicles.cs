using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class Vehicles
    {
        public int price;
        public string type;
        public Vehicles()
        {
        }
        public override string ToString()
        {
            return String.Format("Type of vehicle: {0}   |   Price: {1}", type, price.ToString("C2"));
        }

    }
}
