MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
strTarget("Some string data");

MyGenericDelegate<int> intTarget = IntTarget;
intTarget(9);
Console.ReadLine();

static void StringTarget(string str)
{
    Console.WriteLine($"str in uppercase is: {str.ToUpper()}");
}
static void IntTarget(int arg)
{
    Console.WriteLine($"++arg is: {++arg}");
}

public delegate void MyGenericDelegate<T>(T arg);