static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
{
    ConsoleColor prev = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;
    for(int i = 0; i < printCount; i++) { Console.WriteLine(msg); }
    Console.ForegroundColor = prev;
}
static string Add(int a, int b)
{
    return (a + b).ToString();
}
static int AddInt(int a, int b)
{
    return a + b;
}
Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget("Action Message!", ConsoleColor.Yellow, 5);

Func<int, int, int> addMe = AddInt;
Console.WriteLine(addMe(5, 2).ToString());

Func<int, int, string> addMe2 = Add;
Console.WriteLine(addMe2(5, 3));