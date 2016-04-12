using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomIteratorAirplane newFlight = new CustomIteratorAirplane();
            List<Flights> flights = newFlight.addFlights();
            newFlight.flightstuff();
            
            Console.ReadKey();
        }
    }




}


