using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverCollections
{
    internal class Car
    {
        public int Speed { get; set; } 
        public string Color { get; set; } = "";
        public string PetName { get; set; } = "";
        public string Make { get; set; } = "";
        public Car()
        {
            
        }
        public Car(string name, string make, string color, int speed)
        {
            this.PetName = name;
            this.Make = make;
            this.Color = color;
            this.Speed = speed;
        }
    }
}
