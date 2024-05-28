using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsStats.Models
{
    public class Planet
    {
        public String Name { get; set; }
        public double? Population { get; set; }
        public double? Diameter { get; set; }
        public double? SurfaceWater { get; set; }

        public Planet(string name, string population, string diameter, string surfaceWater)
        {
            Name = name;
            Population = GetValue(population);
            Diameter = GetValue(diameter);
            SurfaceWater = GetValue(surfaceWater);
        }

        //public static implicit operator Planet(Result planet) 
        //{
        //    return new Planet(
        //        planet.name,
                
        //        );
        //}

        public double? GetValue(string value)
        {
            if (value == "unknown")
            {
                return null;
            }
            return double.Parse(value);
        }
            
    }
}
