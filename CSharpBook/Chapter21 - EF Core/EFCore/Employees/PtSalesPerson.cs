using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal sealed class PtSalesPerson:SalesPerson //part-time sales person, sealed measn this can't be derived/inherited
    {
        public PtSalesPerson(string name, int age, int id, float pay, string ssn, DateTime hireDate, int numSales)
        : base(name, id, age, pay, ssn,hireDate,numSales){ }
    }

}
