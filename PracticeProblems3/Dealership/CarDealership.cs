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
        public string getCustomerInfo()
        {
            lotInventory[2].price -= 200;
            customers = reader.getCustomers();
            string firstName;
            string lastName;
            string fullName;
            Console.WriteLine("Welcome to the dealship! My name is Dan, and you are?");
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
            Console.WriteLine("So you'd like to buy a car {0}? Well, we've got a great stock for you to look at. Would you like to see a coupe, sedan, sports car, suv or truck?", name);
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
    }
}
//Inheritance, Properties, Generics, Interfaces/Abstract Classes
//-    A new auto dealership in a populated area in demand for new vehicles needs several types of vehicles available to be sold early next week. 
    /*INCOMPLETE*/
//-    The auto dealership also needs the ability to test the vehicles, sell the vehicles, raise/lower the price of a vehicle, have a special sales event that will set select vehicles at a discount price. 

//-    There are plenty of opportunities to use properties, generics, interfaces/abstract classes. Also, make sure to use the appropriate access modifiers (public, private, protected).

    /*COMPLETE*/
//-    *****It is the job of the car manufacturer to supply the auto dealership with as many different types of vehicles as possible. Since there is a time demand for the vehicles, it is essential to have the car factory be as efficient as possible. Use inheritance to efficiently create multiple types of vehicles for the dealership. 
//-    *****Create an auto dealership class that has the ability to put in an order for vehicles and add a specific vehicle to its fleet of vehicles. 
//-    *****Write to a .txt file a customer’s ID number, name, and vehicle the customer purchased. Each customer should be printed to a different line in the .txt file. Read from the .txt file so there is persistent data in the program (if the program is stopped and ran again, it is possible to see which customers purchased what vehicles). 