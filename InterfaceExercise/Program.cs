using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*DONE Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*DONE Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var truck = new Truck()
            {
                TowingLimit = 8200,
                BedSize = 66,
                Logo = "Blue ford oval",
                Name = "Ford Raptor",
                NumberDoors = 4,
                NumberWheels = 4,
                Year = 2022,
                EngineSize = "5.2L V8"

            };
            var car = new Car()
            {
                Compact = true,
                trunk = true,
                Logo = "Fancy H",
                Name = "Honda Civic",
                NumberDoors = 4,
                NumberWheels = 4,
                Year = 2018,
                EngineSize = "2.0L 4 cylinder"
            };
            var suv = new Suv()
            {
                CargoSpace = "17.2 ft³",
                ThirdRowSeats = true,
                Logo = "Red ram",
                Name = "Dodge Durango",
                NumberDoors = 4,
                NumberWheels = 7,
                Year = 2022,
                EngineSize = "3.6L V6"
            };
            
            var car1 = new List<Car>();
            var suv1 = new List<Suv>();
            var truck1 = new List<Truck>();
            suv1.Add(suv);
            car1.Add(car);
            truck1.Add(truck);

            foreach (var vehicle in car1)
            {
                Console.WriteLine($"Name {vehicle.Name}, Logo {vehicle.Logo}");
                Console.WriteLine($"Number of doors {vehicle.NumberDoors}, Number of wheels {vehicle.NumberWheels}, Year {vehicle.Year}, Engine Size {vehicle.EngineSize}");
                Console.WriteLine($"Is this a compact vehicle {vehicle.Compact}, Does this vehicle have a trunk {vehicle.trunk}");
                Console.WriteLine("---------------------------");

            }
            foreach (var vehicle in suv1)
            {
                Console.WriteLine($"Name {vehicle.Name}, Logo {vehicle.Logo}");
                Console.WriteLine($"Number of doors {vehicle.NumberDoors}, Number of wheels {vehicle.NumberWheels}, Year {vehicle.Year}, Engine Size {vehicle.EngineSize}");
                Console.WriteLine($"How large is the cargo space {vehicle.CargoSpace}, does this SUV have third row seating {vehicle.ThirdRowSeats}");
                Console.WriteLine("---------------------------");

            }
            foreach (var vehicle in truck1)
            {
                Console.WriteLine($"Name {vehicle.Name}, Logo {vehicle.Logo}");
                Console.WriteLine($"Number of doors {vehicle.NumberDoors}, Number of wheels {vehicle.NumberWheels}, Year {vehicle.Year}, Engine Size {vehicle.EngineSize}");
                Console.WriteLine($"The towing limit of this truck is {vehicle.TowingLimit}, the bed size of the truck is {vehicle.BedSize}");
                Console.WriteLine("---------------------------");

            }
        }
    }
}
