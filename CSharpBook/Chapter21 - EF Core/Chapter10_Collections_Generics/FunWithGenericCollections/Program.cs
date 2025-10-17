using FunWithGenericCollections;

static void UseGenericList()
{
    List<Person> lp = new List<Person>()
    {
        new Person {FirstName= "Homer", LastName="Simpson", Age=47},
        new Person {FirstName= "Marge", LastName="Simpson", Age=45},
        new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
        new Person {FirstName= "Bart", LastName="Simpson", Age=8}
    };
    Console.WriteLine($"items in list {lp.Count}");

    foreach (Person p in lp) { Console.WriteLine(p); }
    Console.WriteLine("\n->Inserting new person");
    lp.Insert(2, new Person("Maggie", "simpson", 99));
    Console.WriteLine($"items in list {lp.Count}");

    //copy
    Person[] arrP = lp.ToArray();
    foreach (Person p in arrP) { Console.WriteLine($"First names: {p.FirstName}"); }

}
//UseGenericList();
static void UseGenericStack()
{
    Stack<Person> persons = new();
    persons.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
    persons.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
    persons.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

    Console.WriteLine($"\n1st person is {persons.Peek()}");
    Console.WriteLine($"popped off {persons.Pop()}");
    Console.WriteLine($"\n1st person is {persons.Peek()}");
    Console.WriteLine($"popped off {persons.Pop()}");
    Console.WriteLine($"\n1st person is {persons.Peek()}");
    Console.WriteLine($"popped off {persons.Pop()}");
    try
    {
        Console.WriteLine($"\n\n1st person is {persons.Peek()}");
        Console.WriteLine($"popped off {persons.Pop()}");
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"\nError: {e.Message}");
    }


}
//UseGenericStack();
static void UseGenericQueue()
{
    Queue<Person> p = new();
    p.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
    p.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
    p.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

    Print();
    Console.WriteLine($"\n{p.Dequeue()} got coffee!");
  
    Console.WriteLine($"{p.Dequeue()} got coffee!");

    
    Console.WriteLine($"{p.Dequeue()} got coffee!");

    Print();
    void Print()
    {
        Console.WriteLine("\n");
        foreach (Person person in p)
        {
            Console.WriteLine(person);
        }

    }

}
//UseGenericQueue();
static void UseSortedSet()
{
    SortedSet<Person> p = new SortedSet<Person>(new SortPeopleByAge())
    {
        new Person {FirstName= "Homer", LastName="Simpson", Age=47},
        new Person {FirstName= "Marge", LastName="Simpson", Age=45},
        new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
        new Person {FirstName= "Bart", LastName="Simpson", Age=8}
    };

    foreach(Person person in p) {  Console.WriteLine(person); }
}
//UseSortedSet();
static void UseDictionary()
{
    Dictionary<string, Person> p = new Dictionary<string, Person>();
    p.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
    p.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
    p.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
    p.Add("Bart", new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 });

    Console.WriteLine($"{p["Bart"]}");
    Console.WriteLine($"{p.Keys}");

    foreach ((string k, Person person) in p) { Console.WriteLine($"{k}: {person}" ); }
    Console.WriteLine( "\n");

    //populate with collection initialization syntax
    Dictionary<string,Person> isp = new Dictionary<string, Person>()
    {
        {"Homer", new Person {FirstName= "Homer", LastName="Simpson", Age=47} },
        {"Marge", new Person {FirstName= "Marge", LastName="Simpson", Age=45} },
        {"Lisa", new Person {FirstName= "Lisa", LastName="Simpson", Age=9} },
        {"Bart", new Person {FirstName= "Bart", LastName="Simpson", Age=8} }
    };
    Person b = isp["Lisa"];
    Console.WriteLine(b);

    // Populate with dictionary initialization syntax.
    Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
    {
        ["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
        ["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
        ["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }
    };

}
UseDictionary();