using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class Menu
    {
        CarDealership carDealership = new CarDealership();
        public void mainMenu()
        {
            int userType = 0;
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Hello, are you, a(n)... \n\r1) Employee? \n\r2) Customer? \n\r3) Shutdown the computer.");
                bool check = int.TryParse(Console.ReadLine(), out userType);
                if (!check) { mainMenu(); }
                if (userType.Equals(1))
                {
                    dealerActions();
                }
                else if (userType.Equals(2))
                {
                    string fullName = carDealership.getCustomerInfo();
                    customerActions(fullName);
                }
                else if (userType.Equals(3)) { run = false; }
            }            
        }
        
        public void customerActions(string fullName)
        {
            int carSelection = 0;
            string choice;
            Console.WriteLine("Well, {0} we've got some great deals that I would love to show you. How about we look at the cars available and let you pick one to test drive. (Y/N)?", fullName);
            choice = Console.ReadLine();
            choice = choice.ToLower();
            if (choice.Equals("y"))
            {
                string carType = carDealership.selectACarType();
                carDealership.getInventory(carType);
                carSelection = carDealership.testDrive(fullName);
            }
            else if (choice.Equals("n"))
            {
                carSelection = customerBrowse(fullName);
            }
            buyACar(carSelection);
            Console.ReadKey();
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
                    carDealership.getInventory(null);
                    carDealership.testDrive(null);
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
        public int customerBrowse(string fullName)
        {
            Console.WriteLine("Well perhaps you would like to just go look at what we have and come back...I'll let you go check things out. \n\rpress any key to continue.");
            Console.ReadKey();
            carDealership.getInventory(null);
            Console.WriteLine("Would you like to take any of these cars for a test drive now?");
            string choice2 = Console.ReadLine();
            choice2 = choice2.ToLower();
            if (choice2.Equals("y"))
            {
                int inventorySelection = carDealership.testDrive(fullName);
                return inventorySelection;
            }
            else if (choice2.Equals("n")) { }
            else { return customerBrowse(fullName); }
            return 0;
        }
        public void buyACar(int carSelection)
        {
            int buyType;
            Console.WriteLine("So now that you've test driven a car can I interest you in buying it today? My records show that you were interested in a {0} that is {1}.", carDealership.lotInventory[carSelection].type,carDealership.lotInventory[carSelection].price.ToString("C2"));
            Console.WriteLine("Will you... \n\r1) Pay full price? \n\r2) Ask for a lower price?");
            bool check = int.TryParse(Console.ReadLine(), out buyType);
            if (!check) { Console.WriteLine("Invalid Selection."); buyACar(carSelection); }
            if (buyType.Equals(1))
            {
                Console.WriteLine("Great, the car is yours! Thank you for your purchase!");
                carDealership.finalizeSale(carSelection, 0);
            }
            else if (buyType.Equals(2))
            {
                int askPrice;
                bool sell = true;
                while(sell == true)
                {
                    Console.WriteLine("The normal price is {0}, what would you like to pay for it?", carDealership.lotInventory[carSelection].price);
                    bool check1 = int.TryParse(Console.ReadLine(), out askPrice);
                    sell = carDealership.hagglePrice(carSelection, askPrice);
                }
            }
            else { Console.WriteLine("Invalid choice."); buyACar(carSelection); }
            
        }
    }
}