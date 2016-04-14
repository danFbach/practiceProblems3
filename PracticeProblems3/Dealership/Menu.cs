using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class Menu
    {
        CarDealership carDealership = new CarDealership();
        public void mainMenu()
        {
            int userType = getUserType();
            if (userType.Equals(1))
            {
                dealerActions();
            }
            else
            {
                string fullName = carDealership.getCustomerInfo();
                customerActions(fullName);
            }
        }
        public int getUserType()
        {
            int userType;
            Console.WriteLine("Hello, are you, a(n)... \n\r1) Employee? \n\r2) Customer? \n\r3) Shutdown the computer.");
            bool check = int.TryParse(Console.ReadLine(), out userType);
            if (!check) { return getUserType(); }
            if(userType.Equals(1) || userType.Equals(2)){ return userType; }
            else if (userType.Equals(3)) { }
            return getUserType();           
        }        
        public void customerActions(string fullName)
        {
            string choice;
            Console.WriteLine("Well, {0} we've got some great deals that I would love to show you. How about we look at the cars available and let you pick one to test drive. (Y/N)?", fullName);
            choice = Console.ReadLine();
            choice = choice.ToLower();
            if (choice.Equals("y"))
            {
                carDealership.buyACar();
            }
            else if (choice.Equals("n"))
            {
                customerBrowse(fullName);
            }
        }
        public void dealerActions()
        {
            int employeeChoice;
            Console.WriteLine("Ok, what is it that you need to do today?");
            Console.WriteLine("\n\r1) View current inventory. \n\r2)Order more cars from the factory. \n\r3)Test Drive a car from you inventory. \n\r4)Have an awesome sales event!");
            bool check = int.TryParse(Console.ReadLine(), out employeeChoice);
            if (!check) { dealerActions(); }
            switch (employeeChoice)
            {
                case (1):
                    carDealership.getInventory(null);
                    break;
                case (2):
                    carDealership.placeAnOrder();
                    break;
                case (3):
                    carDealership.testDrive();
                    break;
                case (4):
                    carDealership.salesEvent();
                    break;
                default:
                    dealerActions();
                    break;
            }
            Console.WriteLine("Would you like to continue using the computer as an employee? (Y/N)");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            if (choice.Equals("y")) { dealerActions(); }
        }
        public void customerBrowse(string fullName)
        {
            Console.WriteLine("Well perhaps you would like to just go look at what we have and come back...I'll let you go check things out. \n\rpress any key to continue.");
            Console.ReadKey();
            carDealership.getInventory(null);
            Console.WriteLine("Would you like to take any of these cars for a test drive now?");
            string choice2 = Console.ReadLine();
            choice2 = choice2.ToLower();
            if (choice2.Equals("y"))
            {
                carDealership.testDrive();
            }
            else if (choice2.Equals("n")) { }
            else { customerBrowse(fullName); }
        }
    }
}

//-    Create a customer class that has the ability to test drive a vehicle, haggle in an attempt to get the price down, purchase a vehicle. Also, the customer must have a name and ID number.