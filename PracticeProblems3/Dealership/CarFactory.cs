using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class CarFactory
    {
        enum vehicleMake { Chevrolet, Ford, VolksWagen, Audi, Honda };
        enum vehicleType { Coupe, Sedan, SportsCar, Truck, SUV };

        List<Vehicles> vehicles = new List<Vehicles>();

        public void buildVehicles()
        {
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.Coupe));
            vehicles.Add(new Vehicles(vehicleMake.Chevrolet, vehicleType.Sedan));
            vehicles.Add(new Vehicles(vehicleMake.VolksWagen, vehicleType.SportsCar));
            vehicles.Add(new Vehicles(vehicleMake.Honda, vehicleType.Sedan));
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.Truck));
            vehicles.Add(new Vehicles(vehicleMake.Audi, vehicleType.Coupe));
            vehicles.Add(new Vehicles(vehicleMake.Honda, vehicleType.SportsCar));
            vehicles.Add(new Vehicles(vehicleMake.Honda, vehicleType.Coupe));
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.Truck));
            vehicles.Add(new Vehicles(vehicleMake.Chevrolet, vehicleType.SportsCar));
            vehicles.Add(new Vehicles(vehicleMake.VolksWagen, vehicleType.SUV));
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.Sedan));
            vehicles.Add(new Vehicles(vehicleMake.Honda, vehicleType.Coupe));
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.Truck));
            vehicles.Add(new Vehicles(vehicleMake.VolksWagen, vehicleType.SUV));
            vehicles.Add(new Vehicles(vehicleMake.Honda, vehicleType.SUV));
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.Truck));
            vehicles.Add(new Vehicles(vehicleMake.Audi, vehicleType.Coupe));
            vehicles.Add(new Vehicles(vehicleMake.Chevrolet, vehicleType.Truck));
            vehicles.Add(new Vehicles(vehicleMake.Chevrolet, vehicleType.SUV));
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.SportsCar));
            vehicles.Add(new Vehicles(vehicleMake.Honda, vehicleType.Coupe));
            vehicles.Add(new Vehicles(vehicleMake.VolksWagen, vehicleType.Sedan));
            vehicles.Add(new Vehicles(vehicleMake.Audi, vehicleType.Coupe));
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.SUV));
            vehicles.Add(new Vehicles(vehicleMake.VolksWagen, vehicleType.SUV));
            vehicles.Add(new Vehicles(vehicleMake.Audi, vehicleType.Coupe));
            vehicles.Add(new Vehicles(vehicleMake.Chevrolet, vehicleType.Sedan));
            vehicles.Add(new Vehicles(vehicleMake.Ford, vehicleType.SUV));
        }
    }
}
