using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneProject
{
    public class Engine
    {
       
        public int Horsepower { get; set; }       
        public double FuelConsumption { get; set; } 
        public string Type { get; set; }          

        
        public Engine(int horsepower, double fuelConsumption, string type)
        {
            Horsepower = horsepower;
            FuelConsumption = fuelConsumption;
            Type = type;
        }

       
        public double CalculateFuelEfficiency()
        {
            return Horsepower / FuelConsumption;
        }
    }
}
