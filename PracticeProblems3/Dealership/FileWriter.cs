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
                    string firstName = customer.firstName;
                    string lastName = customer.lastName;
                    int idNumber = customer.customerID;
                    string carTypePurchased = customer.carTypePurchased;
                    int purhcasePrice = customer.purchasePrice;
                    customerDatabase.WriteLine("{0},{1},{2},{3},{4}", firstName, lastName, idNumber, carTypePurchased, purhcasePrice);
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
