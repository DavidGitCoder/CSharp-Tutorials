using CustomGenericMethods;

int a = 4, b = 5;
SwapFunctions.Swap<int>(ref a, ref b);
Person p1 = new("Homer", "Simpson", 45);
Person p2 = new("Marge", "Simpson", 42);
Console.WriteLine(p1);
Console.WriteLine(p2);
SwapFunctions.Swap<Person>(ref p1, ref p2);
Console.WriteLine(p1);
Console.WriteLine(p2);