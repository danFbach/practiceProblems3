using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeProblems3.Dealership;

namespace PracticeProblems3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //FLIGHTS
            //CustomIteratorAirplane newFlight = new CustomIteratorAirplane();
            //newFlight.addFlights();
            //newFlight.flightstuff();

            //HUMANE SOCIETY
            //HumaneSociety humaneSociety = new HumaneSociety();
            //humaneSociety.displayAnimals();

            //WEATHER FORECAST
            //Weather weather = new Weather();
            //weather.displayForecast();

            //CAR DEALERSHIP
            CarDealership carDealership = new CarDealership();
            carDealership.placeAnOrder();

            //BIRTHDAY
            //OverloadBirthday bday = new OverloadBirthday();
            //bday.displayPeople();
            //int personIndex = bday.getPerson();
            //bday.trythis(personIndex);         
            
            //WEATHER
            //Weather weather = new Weather();
            //weather.displayForecast();  

        }
    }
}


