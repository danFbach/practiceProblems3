using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PracticeProblems3.Dealership
{
    public class Vehicle : IDriveable<Vehicle>
    {
        private int Price;
        public string type;
        public Vehicle()
        {
        }
        public int price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
            
        }
        public int speed = 0;
        public void accelerate()
        {
            speed += 20;
            if (speed > 80) { speed = 80; Console.WriteLine("You've reached the maximum speed of this vehicle."); }
            Console.WriteLine("Your current speed is {0}.",speed);
        }
        public void deccelerate()
        {
            speed -= 20;
            if (speed == 0) { Console.WriteLine("You've come to a stop."); }
            else if (speed < 0) { speed = 0; Console.WriteLine("You're currently at a stop, you cannot decelerate any further."); }
            else { Console.WriteLine("Your current speed is {0}.", speed); }
        }
        public void returnToDealer()
        {
            Console.WriteLine("Vroom Vroom!!");
            for(int i = 0; i < 75; i++)
            {
                Console.Write(".");
                Thread.Sleep(25);
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return String.Format("Type of vehicle: {0}   |   Price: {1}", type, price.ToString("C2"));
        }

    }
}
