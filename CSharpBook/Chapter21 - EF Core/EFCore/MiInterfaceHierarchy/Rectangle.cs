using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MiInterfaceHierarchy
{
    internal class Rectangle : IShape
    {
        void IDrawable.Draw() => Console.WriteLine("Drawing a Rectangle...");
        void IPrintable.Draw() => Console.WriteLine("Drawing a Rectanle in the printer");
        public int GetNumberOfSides() => 4;
        public void Print()
        {
            Console.WriteLine("Printing the rectangle...");
        }
    }
}
