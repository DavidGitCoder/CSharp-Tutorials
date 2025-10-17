using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    internal class PersonCollection:IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        public Person GetPerson(int pos)=> (Person)arPeople[pos];
        public void AddPerson(Person person)
        {
            arPeople.Add(person);
        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }
        public int Count => arPeople.Count;
        public IEnumerator GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }
    }
}
