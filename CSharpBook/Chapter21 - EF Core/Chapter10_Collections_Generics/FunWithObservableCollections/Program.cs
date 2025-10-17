using FunWithObservableCollections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

ObservableCollection<Person> p = new ObservableCollection<Person>()
{
    new Person {FirstName= "Homer", LastName="Simpson", Age=47},
    new Person {FirstName= "Marge", LastName="Simpson", Age=45},
    new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
    new Person {FirstName= "Bart", LastName="Simpson", Age=8}
};
p.CollectionChanged += people_CollectionChanged;
p.Add(new Person("Maggie","Simpson",2 ));
p.RemoveAt(0);
static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine($"Action for this event: {e.Action}");

    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are the old items: ");
        foreach(Person p in e.OldItems)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine();
    }
    if(e.Action == NotifyCollectionChangedAction.Add)
    {
        Console.WriteLine("Here are the NEW items:");
        foreach(Person p in e.NewItems)
        {
            Console.WriteLine(p.ToString());
        }
    }
}