using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeProblems3.Dealership
{
    public class FileReader
    {
        public string customers = "../../Dealership/CustomerDatabase";
        public string inventoryFile = "../../Dealership/VehicleInventory.csv";
        public string line = "";
        public char divider = ',';
        public List<Customer> customerData = new List<Customer>();
        public List<Vehicle> inventory = new List<Vehicle>();

        public List<Customer> getCustomers()
        {
            customerData.Clear();
            using(StreamReader getCustData = new StreamReader(customers))
            {
                while((line = getCustData.ReadLine()) != null)
                {
                    string[] decodeCustomer = line.Split(divider);
                    string name = decodeCustomer[0];
                    string idNum = decodeCustomer[1];
                    string carPreference = decodeCustomer[2];
                    int customerID = Convert.ToInt16(idNum);
                    customerData.Add(new Customer(name, customerID, carPreference));
                }
                return customerData;
            }
        }
        public List<Vehicle> getVehicles()
        {
            inventory.Clear();
            using(StreamReader getInventory = new StreamReader(inventoryFile))
            {
                while((line = getInventory.ReadLine()) != null)
                {
                    string[] decodeInventory = line.Split(divider);
                    string type = decodeInventory[0];
                    string price = decodeInventory[1];
                    int carPrice = Convert.ToInt16(price);

                    switch (type)
                    {
                        case ("Coupe"):
                            inventory.Add(new Coupe(carPrice));
                            break;
                        case ("Sedan"):
                            inventory.Add(new Sedan(carPrice));
                            break;
                        case("Sports Car"):
                            inventory.Add(new SportsCar(carPrice));
                            break;
                        case ("SUV"):
                            inventory.Add(new SUV(carPrice));
                            break;
                        case ("Truck"):
                            inventory.Add(new Truck(carPrice));
                            break;
                    }
                }
                return inventory;
            }
        }
    }
}
