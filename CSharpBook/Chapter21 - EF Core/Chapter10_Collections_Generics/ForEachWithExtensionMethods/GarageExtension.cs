using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWithExtensionMethods
{
    internal static class GarageExtension
    {
        public static IEnumerator GetEnumerator(this Garage g)
        {
            return g.CarsInGarage.GetEnumerator();
        }
    }
}
