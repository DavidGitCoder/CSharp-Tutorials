using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    internal class Person:IComparable<Person>
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {
            
        }
        public Person(string fn, string ln, int a)
        {
            Age=a; FirstName=fn; LastName=ln;
        }
        public override string ToString() {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }
    }
}
