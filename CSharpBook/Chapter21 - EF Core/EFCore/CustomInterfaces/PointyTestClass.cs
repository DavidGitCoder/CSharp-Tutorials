using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class PointyTestClass : IPointy, IRegularPointy
    {
        public byte Points => throw new NotImplementedException();

        int IRegularPointy.SideLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IRegularPointy.NumberOfSides { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        byte IPointy.Points => throw new NotImplementedException();
    }
}
