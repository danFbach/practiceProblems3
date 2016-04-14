using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using PracticeProblems3.Dealership;


namespace PracticeProblems3
{
    public class CarDealership
    {
        public List<Vehicle> lotInventory = new List<Vehicle>();
        List<Customer> customers = new List<Customer>();
        Vehicle vehicle = new Vehicle();
        FileWriter writer = new FileWriter();
        FileReader reader = new FileReader();
        CarFactory carFactory = new CarFactory();
        public int idNumber;
        public CarDealership()
        {
            lotInventory = reader.getVehicles();
        }
        public void finalizeSale(int carNumber, int hagglePrice)
        {
            string firstName = customers[idNumber].firstName;
            string lastName = customers[idNumber].lastName;
            string carType = lotInventory[carNumber].type;
            int amountPaid = lotInventory[carNumber].price;
            if(hagglePrice > 0) { amountPaid = hagglePrice; }
            customers.Insert(idNumber,new Customer(firstName, lastName, idNumber, carType, amountPaid));
            customers.RemoveAt(idNumber+1);
            lotInventory.RemoveAt(carNumber);
            writer.updateCustomers(customers);
            writer.vehicleInventory(lotInventory);
        }
        public string getCustomerInfo()
        {
            customers = reader.getCustomers();
            string firstName;
            string lastName;
            string fullName;
            Console.WriteLine("Welcome to the dealership! My name is Dan, and you are?");
            firstName = Console.ReadLine();
            Console.WriteLine("And your last name?");
            lastName = Console.ReadLine();
            idNumber = customers.Count;
            customers.Add(new Customer(firstName, lastName, idNumber, "no purchase", 0));
            writer.updateCustomers(customers);
            fullName = firstName + " " + lastName;
            return fullName;
        }
        public string selectACarType()
        {
            string name = customers[idNumber].firstName;
            string modelSelection;
            Console.WriteLine("So you'd like to test a car {0}? Well, we've got a great stock for you to look at. Would you like to see a coupe, sedan, sportscar, suv or truck?", name);
            modelSelection = Console.ReadLine();
            modelSelection = modelSelection.ToLower();
            return modelSelection;
        }
        public int placeAnOrder()
        {
            int typeOfCar = carFactory.orderType();
            int orderQty = carFactory.orderQuantity(typeOfCar);
            List<Vehicle> tempInventory = carFactory.OrderVehicles(orderQty, typeOfCar);
            lotInventory.AddRange(tempInventory);
            tempInventory.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Here's your new list of inventory.");
            Console.ResetColor();
            getInventory(null);
            writer.vehicleInventory(lotInventory);
            Console.WriteLine("\n\rWould you like to place another order? (Y/N)");
            string reorder = Console.ReadLine();
            reorder = reorder.ToLower();
            if (reorder.Equals("y")) { Console.Clear(); return placeAnOrder(); }
            else if (reorder.Equals("n")) { return 0; }
            else { return placeAnOrder(); }
        }
        public void getInventory(string carTypeSelection)
        {
            int number = 0;
            foreach (Vehicle vehicle in lotInventory)
            {
                if(vehicle.type == carTypeSelection)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Stock #:{0}", number);
                    Console.ResetColor();
                    sleep(5, 50);
                    Console.WriteLine(" {0}", vehicle);
                    number++;
                }
                else if (carTypeSelection == null)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Stock #:{0}", number);
                    Console.ResetColor();
                    sleep(5,50);
                    Console.WriteLine(" {0}", vehicle);                    
                    number++;
                }
                else
                number++;
            }
        }
        public int testDrive(string name)
        {
            int inventoryNumber;
            Console.WriteLine("Please enter the inventory number of the car you would like to test.");
            bool check = int.TryParse(Console.ReadLine(), out inventoryNumber);
            if (!check) { Console.WriteLine("Invalid Entry"); testDrive(name); }
            if(inventoryNumber > lotInventory.Count) { Console.WriteLine("Not a valid car selection."); testDrive(name); }
            else
            {
                Console.WriteLine("Great! I will pull that car right up for you {0}.",name);
                sleep(25, 75);
                driving(lotInventory[inventoryNumber]);
                return inventoryNumber;
            }
            return inventoryNumber;
        }
        public void salesEvent()
        {
            string carToPutOnSale;
            int newPrice;
            Console.WriteLine("What type of car would you like to put on sale? coupe, sedan, sportscar, truck or suv?");
            carToPutOnSale = Console.ReadLine();            
            Console.WriteLine("And what would you like to new price to be?");
            bool check = int.TryParse(Console.ReadLine(), out newPrice);
            if (!check) { salesEvent(); }

            foreach(Vehicle vehicle in lotInventory)
            {
                if (carToPutOnSale.Equals(vehicle.type))
                {
                    vehicle.price = newPrice;
                }
            }
            Console.WriteLine("Here is your updated inventory.");
            getInventory(null);            
            writer.vehicleInventory(lotInventory);
            Console.ReadKey();
        }
        public void driving(Vehicle selectedVehicle)
        {
            Console.WriteLine("Here's the car that you requested.\n\r{0}");
            bool drive = true;
            while (drive)
            {
                int driveAction;
                Console.WriteLine("Would you like to... \n\r1) Accelerate \n\r2) Deccelerate \n\r3) Return to Dealership");
                bool check = int.TryParse(Console.ReadLine(), out driveAction);
                if (driveAction.Equals(1)) { vehicle.accelerate(); }
                else if (driveAction.Equals(2)) { vehicle.deccelerate(); }
                else if (driveAction.Equals(3)) { vehicle.returnToDealer(); drive = false; }
                else { driving(selectedVehicle); }
            }
        }
        public void sleep(int dots, int delay)
        {
            for (int i = 0; i < dots; i++)
            {
                Console.Write(".");
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
        public bool hagglePrice(int carSelection, int customerOffer)
        {
            int acceptablePrice = Convert.ToInt16(lotInventory[carSelection].price * .95);
            
            if(customerOffer < acceptablePrice)
            {
                Console.WriteLine("I'm sorry that price is too low, you'll have to make another offer.");
                return true;
            }
            else
            {
                Console.WriteLine("Alright, that is an acceptable offer. The car is yours.");
                finalizeSale(carSelection, customerOffer);
                return false;
            }
        }
    }
}