using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class Vehicles
    {
        public Enum make;
        public Enum vehicleType;
        public Vehicles(Enum make,Enum vehicleType)
        {
            this.make = make;
            this.vehicleType = vehicleType;
        }
    }
}
