using IssuesWithNonGenericCollections;
using System.Collections;

static void SimpleBoxUnboxOperation()
{
    int myInt = 25;
    object boxedInt = myInt;
    int unboxedInt = (int)boxedInt;
}
static void WorkWitjArrayList()
{
    ArrayList i = new ArrayList();
    i.Add(1);
    i.Add(2);
    i.Add(3);

    int val = (int)i[0];
    Console.WriteLine(i);

}
//NonGenericCollection();
UseGenericList();
static void NonGenericCollection()
{
    PersonCollection pc = new PersonCollection();
    pc.AddPerson(new Person("John", "Wayne", 86));
    pc.AddPerson(new Person("Marilyn", "Monroe", 60));
    pc.AddPerson(new Person("Franck", "Zappa", 90));
    pc.AddPerson(new Person("Buster", "Keaton", 23));
    foreach (Person p in pc) { Console.WriteLine(p.ToString()); }
}
static void UseGenericList()
{
    List<Person> lp = new List<Person>();
    lp.Add(new Person("Charles", "Aznavour", 77));
    lp.Add(new Person("John", "Wayne", 86));
    lp.Add(new Person("Marilyn", "Monroe", 60));
    lp.Add(new Person("Franck", "Zappa", 90));
    lp.Add(new Person("Buster", "Keaton", 23));
    foreach (Person p in lp) { Console.WriteLine(p.ToString()); }
    Console.WriteLine();
    lp.Sort();
    foreach(Person p in lp) { Console.WriteLine(p.ToString()); }

    List<int> li=new List<int>();
    li.Add(1);
    li.Add(2);
    li.Add(3);
    int sum = li[0] + li[2];
    Console.WriteLine(sum);
    
}
int[] myInts = { 10, 4, 2, 33, 93 };
// Specify the placeholder to the generic
// Sort<>() method.
Array.Sort<int>(myInts);
foreach (int i in myInts)
{
    Console.WriteLine(i);
}