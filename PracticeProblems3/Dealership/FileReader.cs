using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PracticeProblems3.Dealership;

namespace PracticeProblems3
{
    public class FileReader
    {
        public string customers = "../../Dealership/CustomerDatabase.csv";
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
                    string firstName = decodeCustomer[0];
                    string lastName = decodeCustomer[1];
                    string idNum = decodeCustomer[2];
                    string carTypePurchased = decodeCustomer[3];
                    string purchPrice = decodeCustomer[4];
                    int purchasePrice = Convert.ToInt16(purchPrice);
                    int customerID = Convert.ToInt16(idNum);
                    customerData.Add(new Customer(firstName, lastName, customerID, carTypePurchased, purchasePrice));
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
                    int carPrice = Convert.ToInt32(price);

                    switch (type)
                    {
                        case ("coupe"):
                            inventory.Add(new Coupe(carPrice));
                            break;
                        case ("sedan"):
                            inventory.Add(new Sedan(carPrice));
                            break;
                        case("sports car"):
                            inventory.Add(new SportsCar(carPrice));
                            break;
                        case ("suv"):
                            inventory.Add(new SUV(carPrice));
                            break;
                        case ("truck"):
                            inventory.Add(new Truck(carPrice));
                            break;
                    }
                }
                return inventory;
            }
        }
    }
}
