using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class MiniVan: Car, ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
