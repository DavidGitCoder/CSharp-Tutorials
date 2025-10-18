using LambdaExpressions;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
var outerVariable = 0;

Func<int, int, bool> DoWork = static (x, y) =>
{
    //outerVariable++;
    return true;
};
DoWork(3, 4);
Console.WriteLine($"Outer variable now = {outerVariable}");

static void TraditionalDelegateSyntax()
{
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

    
    List<int> evenNumbers = list.FindAll((i) => (i % 2) == 0);

    foreach(int i in evenNumbers)
    {
        Console.Write(i + "\t");
    }
}

TraditionalDelegateSyntax();
Console.WriteLine("\n");

SimpleMath s =  new SimpleMath();
s.SetMathHandler((string msg, int res) => Console.WriteLine($"Returned msg: {msg} with a result of: {res}"));
s.Add(3, 4);

s.SetVerifSimpDelegateHandler(() => Console.WriteLine("Handler has been verified :)"));
s.Verify(4,5);