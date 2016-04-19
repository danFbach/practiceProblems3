using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class CustomIteratorAirplane
    {
        List<Flights> flightPlans = new List<Flights>();
        public CustomIteratorAirplane()
        {   
        }
        public void displayFlights()
        {
            foreach(Flights flight in this)
            {
                Console.WriteLine(flight);
            }
            Console.ReadLine();
        }
        public IEnumerator<Flights> GetEnumerator()
        {
            foreach(Flights flight in flightPlans)
            {
                if(flight.city.Equals("Los Angeles"))
                {                    
                    yield return flight;
                }
            }
        }
        public void addFlights()
        {
            flightPlans.Add(new Flights("New York", 11, 20, 1275));
            flightPlans.Add(new Flights("Denver", 11, 20, 1787));
            flightPlans.Add(new Flights("Chicago", 11 ,23, 5121));
            flightPlans.Add(new Flights("St. Louis", 11 ,40, 512));
            flightPlans.Add(new Flights("Philadelphia", 11 ,45, 4077));
            flightPlans.Add(new Flights("Minneapolis", 11, 48, 4542));
            flightPlans.Add(new Flights("Atlanta", 11, 50, 449));
            flightPlans.Add(new Flights("Washington D.C.", 12, 35, 3456));
            flightPlans.Add(new Flights("Detroit", 12, 38, 671));
            flightPlans.Add(new Flights("Denver", 12, 44, 5165));
            flightPlans.Add(new Flights("Boston", 13, 30, 1292));
            flightPlans.Add(new Flights("Orlando", 13 ,45, 102));
            flightPlans.Add(new Flights("Dallas", 13, 50, 1534));
            flightPlans.Add(new Flights("Phoenix", 14, 10, 2078));
            flightPlans.Add(new Flights("Ft. Meyers", 15, 00, 1783));
            flightPlans.Add(new Flights("Los Angeles", 15, 10, 3259));
            flightPlans.Add(new Flights("Chicago", 15, 15, 5049));
            flightPlans.Add(new Flights("Cleveland", 15, 39, 4401));
            flightPlans.Add(new Flights("San Francisco", 15 ,50, 679));
            flightPlans.Add(new Flights("Charlotte", 16, 20, 5098));
        }
    }
}
//Custom Iterator
//-    Problem 1: You have a flight from Milwaukee to Los Angeles. Unfortunately, you had too much fun staying up and playing video games the night before, which resulted in missing your flight. Iterate through all of the flight numbers leaving Milwaukee to see when you can catch the next flight to Los Angeles. This means having a collection of all flights leaving Milwaukee to the various destinations to iterate through. Use Expedia or any other online resource to gather the flights for a specific date (this means using real data for the lab). Print and return the time of flight and flight number you are taking.