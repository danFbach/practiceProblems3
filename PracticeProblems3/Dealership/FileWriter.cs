using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeProblems3.Dealership
{
    public class FileWriter
    {
        public string customers = "../../Dealership/CustomerDatabase.csv";
        public string inventoryFile = "../../Dealership/VehicleInventory.csv";
        public void updateCustomers(List<Customer> customerList)
        {
            using (StreamWriter customerDatabase = new StreamWriter(customers, false))
            {
                foreach(Customer customer in customerList)
                {
                    string name = customer.name;
                    int idNumber = customer.customerID;
                    string carPreference = customer.carPreference;
                    customerDatabase.WriteLine("{0},{1},{2}", name, idNumber, carPreference);
                }
            }
        }
        public void vehicleInventory(List<Vehicle> vehicles)
        {
            using (StreamWriter lotInventory = new StreamWriter(inventoryFile, false))
            {
                foreach(Vehicle vehicle in vehicles)
                {
                    string type = vehicle.type;
                    int price = vehicle.price;
                    lotInventory.WriteLine("{0},{1}",type, price);
                }
            }
        }        
    }
}
