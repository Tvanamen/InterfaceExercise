using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberDoors { get; set; }
        public int NumberWheels { get; set; }
        public string EngineSize { get; set; }
        public int Year { get; set; }
    }
}
