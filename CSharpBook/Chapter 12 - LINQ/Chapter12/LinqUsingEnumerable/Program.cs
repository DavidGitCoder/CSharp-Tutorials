using LinqUsingEnumerable;
using System.Security.Cryptography.X509Certificates;

static void QueryStringsWithOperators()
{
    Console.WriteLine("***** Using Query Operators *****");
    string[] currentGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

    var subset = from game in currentGames where game.Contains(" ") select game;

    foreach( string game in subset)
    {
        Console.WriteLine($"Item: {game}");
    }
}

QueryStringsWithOperators();

static void QueryStringsWithEnumerableAndLambdas()
{
    Console.WriteLine("\n***** Using Enumerable / Lambda Expressions *****");
    string[] currentGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

    var subset = currentGames
    .Where( game => game.Contains(" ") )
    .OrderBy(game=>game)
    .Select(game=>game);

    foreach( string game in subset)
    {
        Console.WriteLine($"Item: {game}");
    }
}

QueryStringsWithEnumerableAndLambdas();

static void QueryStringsWithAnonymousMedthods()
{
    Console.WriteLine("***** Using Anonymous Methods *****");
    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
    // Build the necessary Func<> delegates using anonymous methods.
    Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" "); };
    Func<string, string> itemToProcess = delegate(string s) { return s; };

    var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess);
    foreach(string game in subset)
    {
        Console.WriteLine($"Item: {game}");
    }
}
Console.WriteLine();
QueryStringsWithAnonymousMedthods();

Console.WriteLine();
VeryComplexQueryExpression.QueryStringsWithRawDelegates();