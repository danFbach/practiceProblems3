using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PracticeProblems3.Dealership;

namespace PracticeProblems3
{
    public class CarFactory
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public Vehicle vehicleType;
        public int orderType()
        {
            int vehicleOrderType;
            Console.WriteLine("What type of car would you like to order? \n\r1) Coupe \n\r2) Sedan \n\r3) Sports Car \n\r4) SUV \n\r5) Truck");
            bool check = int.TryParse(Console.ReadLine(), out vehicleOrderType);
            return check ? vehicleOrderType : orderType();
        }
        public int orderQuantity(int carType)
        {
            string carName = typeIdentifier(carType);
            int orderQty;
            Console.WriteLine("How many {0}'s would you like to order", carName);
            bool check = int.TryParse(Console.ReadLine(), out orderQty);
            return check ? orderQty : orderQuantity(carType);
        }
        public List<Vehicle> OrderVehicles(int numberToMake, int Type)
        {
            int vehicelesMade = 0;
            if (Type.Equals(1))
            {
                vehicleType = new Coupe(15000);
            }
            else if (Type.Equals(2))
            {
                vehicleType = new Sedan(17500);
            }
            else if (Type.Equals(3))
            {
                vehicleType = new SportsCar(45000);
            }
            else if (Type.Equals(4))
            {
                vehicleType = new SUV(27500);
            }
            else if (Type.Equals(5))
            {
                vehicleType = new Truck(25000);
            }
            while (vehicelesMade < numberToMake)
            {
                vehicles.Add(vehicleType);
                vehicelesMade++;
            }
            return vehicles;
        }
        public string typeIdentifier(int carType)
        {
            string carName = "";
            switch (carType)
            {
                case (1):
                    carName = "Coupe";
                    return carName;
                case (2):
                    carName = "Sedan";
                    return carName;
                case (3):
                    carName = "Sports Car";
                    return carName;
                case (4):
                    carName = "SUV";
                    return carName;
                case (5):
                    carName = "Truck";
                    return carName;
                default:
                    return carName;
            }
        }
    }
}