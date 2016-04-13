using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3.Dealership
{
    public class Menu
    {
        public void mainMenu()
        {
            CarDealership carDealership = new CarDealership();
            int userType = getUserType();
            if (userType.Equals(1))
            {
                carDealership.placeAnOrder();
            }
            else
            {
                carDealership.customerMenu();
            }
        }
        public int getUserType()
        {
            int userType;
            Console.WriteLine("Hello, are you, a(n)... \n\r1) Employee? \n\r2) Customer?");
            bool check = int.TryParse(Console.ReadLine(), out userType);
            if (!check) { return getUserType(); }
            return userType;            
        }        
    }
}
