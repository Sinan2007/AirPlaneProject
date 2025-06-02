using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneProject
{
    public class Airplane
    {
        public string Model { get; set; }         
        public int Capacity { get; set; }        
        public IEngine Engine { get; set; }        

        
        public Airplane(string model, int capacity,IEngine engine)
        {
            Model = model;
            Capacity = capacity;
            Engine = engine;
        }

        public string AddEngine(IEngine engine)
        {
            if (Engine == null)
            {
                Engine = engine;
                return "Successfuly added";
            }
            else
            {
                return "The engine is already added";
            }
        }

        public string RemoveEngine()
        {
            if (Engine != null)
            {
                Engine = null;
                return "Successfuly removed";
            }
            else
            {
                return "No engine for removing";
            }
        }
        public double GetRange(double fuelAmount)
        {
            return (fuelAmount / Engine.FuelConsumption) * 800;
        }

        
        public string DescribeAirplane()
        {
            return $"Model: {Model}, Capacity: {Capacity}, Engine Type: {Engine.Type}, Fuel Efficiency: {Engine.CalculateFuelEfficiency()}";
        }
    }
}
