using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Suv : ICompany, IVehicle
    {
        public string CargoSpace { get; set; }
        public bool ThirdRowSeats { get; set; }
        public int NumberDoors { get; set; }
        public int NumberWheels { get; set; }
        public string EngineSize { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
