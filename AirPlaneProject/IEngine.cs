using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneProject
{
    public interface IEngine
    {
         int Horsepower { get; set; }
         double FuelConsumption { get; set; }
         string Type { get; set; }

        double CalculateFuelEfficiency();
    }
}
