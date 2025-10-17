using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    internal class PetNameComparer : IComparer
    {
        int IComparer.Compare(object? o1, object? o2)
        {
            if (o1 is Car c1 && o2 is Car c2)
            {
                return string.Compare(c1.PetName, c2.PetName, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                throw new ArgumentException("Parameters are not a Car!");
            }
        }
    }
}
