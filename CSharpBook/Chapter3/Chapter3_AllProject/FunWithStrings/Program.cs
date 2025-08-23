using System.Runtime.CompilerServices;
using System.Text;
//BasicStringFunctionality();
//EscapeChars();
//StringInterpolation();
//StringInterpolationWithDefaultInterpolatedStringHandler();

//// The following string is printed verbatim,
//// thus all escape characters are displayed.
//Console.WriteLine(@"C:\MyApp\bin\Debug");

//// Whitespace is preserved with verbatim strings.
//string myLongString = @"This is a very
//very
//very
//long string";
//Console.WriteLine(myLongString);

//Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");

//string interp = "interpolation";
//string myLongString2 = $@"This is a very
//very
//long string with {interp}";
//Console.WriteLine(myLongString2);
//StringEquality();

StringEqualitySpecifyingCompareRules();

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

static void StringInterpolationWithDefaultInterpolatedStringHandler()
{
    Console.WriteLine("=> String interpolation under the covers:\a");
    int age = 4;
    string name = "Soren";
    var builder = new DefaultInterpolatedStringHandler(3, 2);
    builder.AppendLiteral("\tHello ");
    builder.AppendFormatted(name);
    builder.AppendLiteral(" you are ");
    builder.AppendFormatted(age);
    builder.AppendLiteral(" years old.");
    var greeting = builder.ToStringAndClear();
    Console.WriteLine(greeting);
}

static void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Test these strings for equality.
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}

static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String equality (Case Insensitive:");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Check the results of changing the default compare rules.
    Console.WriteLine("Default rules: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2,
    s1.Equals(s2));
    Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}",
    s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
    Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
    Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase):{0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
}