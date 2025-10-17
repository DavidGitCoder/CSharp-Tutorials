using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    internal class PersonCollectionStringIndexer:IEnumerable
    {
        private Dictionary<string, Person> listPersons = new Dictionary<string, Person>();
        public Person this[string name]
        {
            get => (Person)listPersons[name];
            set => listPersons[name] = value;
        }
        public void ClearPeople()
        {
            listPersons.Clear();
        }
        public int Count => listPersons.Count;
       IEnumerator IEnumerable.GetEnumerator() => listPersons.GetEnumerator();
        
    }
}
