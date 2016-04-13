using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class CarDealership
    {
        List<Vehicles> lotInventory = new List<Vehicles>();
            CarFactory carFactory = new CarFactory();
        public CarDealership()
        {
        }
        public void placeAnOrder()
        {
            int typeOfCar = carFactory.orderType();
            int orderQty = carFactory.orderQuantity(typeOfCar);
            List<Vehicles> tempInventory = carFactory.OrderVehicles(orderQty, typeOfCar);
            lotInventory.AddRange(tempInventory);
            tempInventory.Clear();
            foreach(Vehicles vehicle in lotInventory)
            {
                Console.WriteLine(vehicle);
            }
            Console.WriteLine("Would you like to place another order? (Y/N)");
            string reorder = Console.ReadLine();
            reorder = reorder.ToLower();

            if (reorder.Equals("y")){ Console.Clear(); placeAnOrder(); }
            
        }
    }
}
//Inheritance, Properties, Generics, Interfaces/Abstract Classes
//-    A new auto dealership in a populated area in demand for new vehicles needs several types of vehicles available to be sold early next week. 
//-    It is the job of the car manufacturer to supply the auto dealership with as many different types of vehicles as possible. Since there is a time demand for the vehicles, it is essential to have the car factory be as efficient as possible. Use inheritance to efficiently create multiple types of vehicles for the dealership. 
//-    Create an auto dealership class that has the ability to put in an order for vehicles and add a specific vehicle to its fleet of vehicles. The auto dealership also needs the ability to test the vehicles, sell the vehicles, raise/lower the price of a vehicle, have a special sales event that will set select vehicles at a discount price. 
//-    Create a customer class that has the ability to test drive a vehicle, haggle in an attempt to get the price down, purchase a vehicle. Also, the customer must have a name and ID number.
//-    Write to a .txt file a customer’s ID number, name, and vehicle the customer purchased. Each customer should be printed to a different line in the .txt file. Read from the .txt file so there is persistent data in the program (if the program is stopped and ran again, it is possible to see which customers purchased what vehicles). 
//-    There are plenty of opportunities to use properties, generics, interfaces/abstract classes. Also, make sure to use the appropriate access modifiers (public, private, protected).
//Enums 