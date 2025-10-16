using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class Car
    {
        public string Make { get; init; }= string.Empty;
        public string Model { get; init; } = string.Empty;
        public string Color { get; init; } = string.Empty;
        public Car() { }
        public Car(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }
    }
}