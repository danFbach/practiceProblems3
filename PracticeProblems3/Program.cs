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
            Console.ForegroundColor = ConsoleColor.White;
            ////FLIGHTS
            //CustomIteratorAirplane newFlight = new CustomIteratorAirplane();
            //newFlight.addFlights();
            //newFlight.flightstuff();

            ////HUMANE SOCIETY
            //HumaneSociety humaneSociety = new HumaneSociety();
            //humaneSociety.displayAnimals();            

            //CAR DEALERSHIP
            Menu menu = new Menu();
            menu.mainMenu();

            ////BIRTHDAY
            //OverloadBirthday bday = new OverloadBirthday();
            //bday.displayPeople();
            //int personIndex = bday.getPerson();
            //bday.selectAPerson(personIndex);

            ////WEATHER
            //Weather weather = new Weather();
            //weather.displayForecast();

        }
    }
}


