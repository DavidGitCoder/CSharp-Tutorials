using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle:Shape
    {
        public Circle(string name) : base(name) { }

        public Circle() { }
        public override void Draw()
        {
            Console.WriteLine($"I'm a Circle () named {PetName}");
        }
    }
}
