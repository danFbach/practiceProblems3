using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class Flights
    {
        public string city;
        public int flightNumber;
        public int hour;
        public int minute;
        public Flights(string city, int hour, int minute, int flightNumber)
        {
            this.hour = hour;
            this.minute = minute;
            this.city = city;
            this.flightNumber = flightNumber;
        }
        public override string ToString()
        {
            return (String.Format("Flight Number: {0} Time: {1}:{2} Location:{3}", flightNumber, hour, minute, city));
        }
    }
}
