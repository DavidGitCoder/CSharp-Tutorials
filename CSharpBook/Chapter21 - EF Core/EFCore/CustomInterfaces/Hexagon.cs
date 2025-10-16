using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class Hexagon : Shape, IPointy
    {
        public Hexagon(string name) : base(name) { }
        public Hexagon() { }

        public override void Draw()
        {
            Console.WriteLine($"I'm an Hexagon called {PetName}");
            Console.WriteLine($@" __");
            Console.WriteLine($@"/  \");
            Console.WriteLine($@"\__/");
        }
        public byte Points => 6;
    }
}
