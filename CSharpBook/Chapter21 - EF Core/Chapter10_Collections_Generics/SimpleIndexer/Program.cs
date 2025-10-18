using SimpleIndexer;
using System.Data;

//PersonCollection p = new PersonCollection();
//p[0] = new Person("Homer", "Simpson", 40);
//p[1] = new Person("Marge", "Simpson", 38);
//p[2] = new Person("Lisa", "Simpson", 9);
//p[3] = new Person("Bart", "Simpson", 7);
//p[4] = new Person("Maggie", "Simpson", 2);
////for(int i=0; i<p.Count; i++)
////{
////    Console.WriteLine(p[i]);
////}

//List<Person> pl = new List<Person>();
//pl.Add(p[0]);
//pl.Add(p[1]);
//pl.Add(p[2]);
//pl.Add(p[3]);
//pl.Add(p[4]);
//pl[0] = new Person("Mickey", "Mouse", 100);
//pl[4] = new Person("Marge", "Simpson", 38);
//pl[3] = new Person("Lisa", "Simpson", 9);
//pl[2] = new Person("Bart", "Simpson", 7);
//pl[1] = new Person("Maggie", "Simpson", 2);


//for (int i = 0; i < pl.Count; i++)
//{
//    Console.WriteLine(pl[i].FirstName);
//}
//Console.WriteLine();

//PersonCollectionStringIndexer psx= new PersonCollectionStringIndexer();
//psx["Homer"]= new Person("Homer", "Simpson", 40);
//psx["Marge"]= new Person("Marge", "Simpson", 38);

//Person homer = psx["Homer"];
//foreach(KeyValuePair<string, Person> kvp in psx)
//{
//    Console.WriteLine(psx);
//}

static void MultiIndexerWithTable()
{
    DataTable myTable= new DataTable();
    myTable.Columns.Add(new DataColumn("FirstName"));
    myTable.Columns.Add(new DataColumn("LastName"));
    myTable.Columns.Add(new DataColumn("Age"));

    myTable.Rows.Add("Mel","Gibson",60);
    Console.WriteLine($"First Name: {myTable.Rows[0][0]}");
    Console.WriteLine($"Last Name: {myTable.Rows[0][1]}");
    Console.WriteLine($"Age: {myTable.Rows[0][2]}");

}
MultiIndexerWithTable();