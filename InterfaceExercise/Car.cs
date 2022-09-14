using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car: ICompany, IVehicle
    {
        public bool Compact { get; set; }
        public bool trunk { get; set; } = true;
        public int NumberDoors { get; set; }
        public int NumberWheels { get; set; }
        public string EngineSize { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
