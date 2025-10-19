static void QueryOverStrings()
{
    string[] currentMovies = { "The 12 bastards", "The Lord Of The Rings", "Titanic", "Forrest Gump", "Friends", "101 and Dalmatians" };
    IEnumerable<string> subset = from m in currentMovies
                                 where m.Contains(" ")
                                 orderby m
                                 select m;
    ReflectOverQueryResults(subset);
    foreach(string movie in subset)
    {
        Console.WriteLine($"Movie: {movie}");
    }

}
static void QueryOverStringsWithExtensionMethods()
{
    string[] currentMovies = { "The 12 bastards", "The Lord Of The Rings", "Titanic", "Forrest Gump", "Friends", "101 and Dalmatians" };
    IEnumerable<string> subset = currentMovies.Where(m => m.Contains(" ")).OrderBy(m => m).Select(g => g);
    
    ReflectOverQueryResults(subset, "Extension Methods");

    foreach(string movie in subset)
    {
        Console.WriteLine($"movie: {movie}");
    }
}
static void ReflectOverQueryResults(object resultSet, string queryType="Query Expressions")
{
    Console.WriteLine($"***** Info about your query using {queryType} *****");
    Console.WriteLine("resultSet is of type {0}", resultSet.GetType().Name);
    Console.WriteLine($"resultSet Location is {resultSet.GetType().Assembly.GetName().Name}");
}
static void QueryOverInts()
{
    int[] nums = { 10, 20, 30, 40, 50, 1, 2, 3, 8 };
    var subset = from i in nums where i < 20 select i;
    foreach(int i in subset)
    {
        Console.WriteLine($"{i} < 20");
    }
    nums[0] = 60;
    foreach (int i in subset)
    {
        Console.WriteLine($"{i} < 20");
    }
    ReflectOverQueryResults(subset);
}
static void ImmediateExecution()
{
    Console.WriteLine();
    Console.WriteLine("Immediate Execution");
    int[] nums = {10,20,30,40,1,2,3,8};

    int n = (from i in nums select i).First();
    Console.WriteLine($"First is {n}");

    n=(from i in nums orderby i select i).First();
    Console.WriteLine($"First is {n}");

    n=(from i in nums where i>30 select i).Single();
    Console.WriteLine($"Single is {n}");

    n=(from i in nums where i>990 select i).SingleOrDefault();
    Console.WriteLine($"SingleOrDefault is {n}");
    n = (from i in nums where i>40 select i).FirstOrDefault();
    Console.WriteLine($"FirstOrDefault is {n}");

    int[] subsetAsIntArray = (from int i in nums where i<10 select i).ToArray<int>();
    List<int> subsetAsList = (from i in nums where i>10 select i).ToList<int>();
}
QueryOverStrings();
QueryOverStringsWithExtensionMethods();
Console.WriteLine();
QueryOverInts();
ImmediateExecution();