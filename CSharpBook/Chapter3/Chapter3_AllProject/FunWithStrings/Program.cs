using System.Runtime.CompilerServices;
using System.Text;
//BasicStringFunctionality();
//EscapeChars();
StringInterpolation();

Console.ReadLine();
static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}",
    firstName.Contains("y"));
    Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();

}
static void EscapeChars()
{
    Console.WriteLine("=> Escape characters:");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name ";
    Console.WriteLine(strWithTabs);
    Console.WriteLine("Everyone loves \"Hello World\" ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug ");
    // Adds a total of 4 blank lines (3 escaped, 1 from WriteLine).
    Console.WriteLine("All finished.\n\n\n ");

    // Adds a 4 more blank lines based on OS
    Console.WriteLine("All finished for real this time.{0}{0}{0}", Environment.NewLine);

    Console.WriteLine();
}

static void StringInterpolation()
{
    Console.WriteLine("=> String interpolation:\a");
    // Some local variables we will plug into our larger string
    int age = 4;
    string name = "Soren";

    // Using curly-bracket syntax.
    string greeting0 = string.Format("Hello {0} you are {1} years old.", name.ToUpper(), age);
    string greeting1 = string.Format("Hello {0} you are {1} years old.", name, age);
    Console.WriteLine(greeting0);
    Console.WriteLine(greeting1);

    // Using string interpolation
    string greeting2 = $"Hello {name} you are {age} years old.";
    string greeting3 = $"Hello {name.ToUpper()} you are {age} years old.";
    Console.WriteLine(greeting2);
    Console.WriteLine(greeting3);

}