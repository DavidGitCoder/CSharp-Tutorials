using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{
    internal record Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Car(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }
    }
}
