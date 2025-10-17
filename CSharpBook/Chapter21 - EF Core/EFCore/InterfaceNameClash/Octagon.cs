using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    internal class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine($"Drawing the Ocatagon on a form");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine($"Drawing the Ocatagon to memory");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine($"Drawing the Ocatagon on a piece of printer paper");
        }
    }
}
