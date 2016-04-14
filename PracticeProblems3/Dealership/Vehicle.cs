using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class Vehicle : IDriveable<Vehicle>
    {
        public int speed = 0;
        public void accelerate()
        {
            speed += 20;
            if(speed > 80)
        }
        public void deccelerate()
        {

        }
        public void returnToDealer()
        {

        }
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
