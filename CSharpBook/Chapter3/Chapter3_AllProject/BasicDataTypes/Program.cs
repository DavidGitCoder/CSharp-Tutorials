using System;
using System.Diagnostics;
//using System;
//using System.Numerics;

//Console.WriteLine("***** Fun with Basic Data Types *****");

//// Multiple comments in one shot: CTRL+C then CTRL + K (or U to uncomment)
////defaultdeclarations();
////localvardeclarations();

////ObjectFunctionality();
////DataTypeFunctionality();
////Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
////Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
////CharFunctionality();
////ParseFromStrings();
////ParseFromStringsWithTryParse();
////UseDatesAndTimes();
////UseBigInteger();
////DigitSeparators();
//BinaryLiterals();

//Console.ReadLine();

//static void LocalVarDeclarations()
//{
//    Console.WriteLine("=> Data Declaration:");
//    // Local variables are declared as so;
//    // dataType varName;
//    int myInt = 0;

//    // You can declare and assign on two lines
//    string myString;
//    myString = "This is my character data";

//    // Declare 3 bools on a single line
//    bool b1 = true, b2 = false, b3 = b1;

//    //Use System.Boolean data type to declare a bool.
//    System.Boolean b4 = false;

//    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
//    Console.WriteLine();
//    Console.ReadLine();
//}

//static void DefaultDeclarations()
//{
//    Console.WriteLine("=> Default Declarations:");
//    int myInt = default;
//    Console.WriteLine(myInt);
//}

//static void ObjectFunctionality()
//{
//    Console.WriteLine("=> System.Object Functionality:");

//    // A C# int is really a shorthand for System.Int32,
//    // which inherits the following members from System.Object.
//    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
//    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
//    Console.WriteLine("12.ToString() = {0}", 12.ToString());
//    Console.WriteLine("12.GetType() = {0}", 12.GetType());

//}

//static void DataTypeFunctionality()
//{
//    Console.WriteLine("=> Data type Functionality:");
//    Console.WriteLine("Max of int: {0}", int.MaxValue);
//    Console.WriteLine("Min of int: {0}", int.MinValue);
//    Console.WriteLine("Max of double: {0}", double.MaxValue);
//    Console.WriteLine("Min of double: {0}", double.MinValue);
//    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
//    Console.WriteLine("double.PositiveInfinity: {0}",
//    double.PositiveInfinity);
//    Console.WriteLine("double.NegativeInfinity: {0}",
//    double.NegativeInfinity);
//    Console.WriteLine();
//}

//static void CharFunctionality()
//{
//    Console.WriteLine("=> char type Functionality:");
//    char myChar = 'a';
//    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
//    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
//    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
//    char.IsWhiteSpace("Hello There", 5));

//    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
//    char.IsWhiteSpace("Hello There", 6));
//    Console.WriteLine("char.IsPunctuation('?'): {0}",
//    char.IsPunctuation('?'));
//    Console.WriteLine();
//}

//static void ParseFromStrings()
//{
//    Console.WriteLine("=> Data type parsing:");
//    bool b = bool.Parse("True");
//    Console.WriteLine("Value of b: {0}", b);
//    double d = double.Parse("99.884");
//    Console.WriteLine("Value of d: {0}", d);
//    int i = int.Parse("8");
//    Console.WriteLine("Value of i: {0}", i);
//    char c = Char.Parse("w");
//    Console.WriteLine("Value of c: {0}", c);
//    Console.WriteLine();
//}

//static void ParseFromStringsWithTryParse()
//{
//    Console.WriteLine("=> Data type parsing with TryParse:");
//    if (bool.TryParse("True", out bool b))
//    {
//        Console.WriteLine("Value of b: {0}", b);
//    }
//    else
//    {
//        Console.WriteLine("Default value of b: {0}", b);
//    }
//    string value = "Hello";
//    if (double.TryParse(value, out double d))
//    {
//        Console.WriteLine("Value of d: {0}", d);
//    }
//    else
//    {
//        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);
//    }
//    Console.WriteLine();
//}

//static void UseDatesAndTimes()
//{
//    Console.WriteLine("=> Dates and Times:");
//    // This constructor takes (year, month, day).
//    DateTime dt = new DateTime(2015, 10, 17);
//    // What day of the month is this?
//    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

//    // Month is now December.
//    dt = dt.AddMonths(2);
//    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
//    // This constructor takes (hours, minutes, seconds).
//    TimeSpan ts = new TimeSpan(4, 30, 0);
//    Console.WriteLine(ts);
//    // Subtract 15 minutes from the current TimeSpan and
//    // print the result.
//    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

//    // new types to match MSSQL types for Dates and Times
//    DateOnly d = new DateOnly(2021, 07, 21);
//    Console.WriteLine(d);
//    TimeOnly t = new TimeOnly(13, 30, 0, 0);
//    Console.WriteLine(t);
//}

//static void UseBigInteger()
//{
//    Console.WriteLine("=> Use BigInteger:");
//    BigInteger biggy =
//    BigInteger.Parse("9999999999999999999999999999999999999999999999");
//    Console.WriteLine("Value of biggy is {0}", biggy);
//    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
//    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
//    BigInteger reallyBig = BigInteger.Multiply(biggy,
//    BigInteger.Parse("8888888888888888888888888888888888888888888"));
//    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
//}

//static void DigitSeparators()
//{
//    Console.WriteLine("=> Use Digit Separators:");
//    Console.Write("Integer:");
//    Console.WriteLine(123_456);
//    Console.Write("Long:");
//    Console.WriteLine(123_456_789L);

//    Console.Write("Float:");
//    Console.WriteLine(123_456.1234F);
//    Console.Write("Double:");
//    Console.WriteLine(123_456.12);
//    Console.Write("Decimal:");
//    Console.WriteLine(123_456.12M);
//    //Updated in 7.2, Hex can begin with _
//    Console.Write("Hex:");
//    Console.WriteLine(0x_00_00_FF);
//}

//static void BinaryLiterals()
//{
//    //Updated in 7.2, Binary can begin with _
//    Console.WriteLine("=> Use Binary Literals:");
//    Console.WriteLine("Sixteen: {0}", 0b_0001_0000);
//    Console.WriteLine("Thirty Two: {0}", 0b_0010_0000);
//    Console.WriteLine("Sixty Four: {0}", 0b_0100_0000);
//}

//Votre entreprise fabrique des capteurs de radioactivité. Vous êtes responsable de leur processus de vérification. Vous savez que lorsqu'un capteur est défaillant, la valeur qu'il délivre présente de grandes variations sur de courtes périodes.

//Le paramètre d'entrée values, une liste de nombres décimaux, contient la radioactivité mesurée par le capteur chaque seconde, en unité arbitraire.

//Vous voulez compter la quantité de "pics" dans ces valeurs, ce qui vous aidera à déterminer si le capteur est défectueux.

//    Lorsqu'une valeur est supérieure d'au moins 5 unités à ses deux voisines, il s'agit d'un "pic supérieur".
//    Lorsqu'une valeur est inférieure d'au moins 5 unités à ses deux voisines, il s'agit d'un "pic inférieur".
//    Vous devez renvoyer un entier : le nombre total de pics supérieurs et de pics inférieurs.

//Le premier et le dernier élément de values ne peuvent jamais être des pics.

//values est toujours défini (pas de null, None ou autre valeur de ce type) et contient entre 0 et 20 éléments.

//Les valeurs de radioactivité sont comprises entre 0 et 100.
//Exemple
//Avec ces valeurs :

//8; 10.7; 17.1; 11.2; 13.5; 9.9; 14.9; 9.4; 9.4; 3.1; 12.7


//Le graphique correspondant est celui-ci :


//    La valeur à l'indice 2 est 17,1. La valeur juste avant est 10,7 et la valeur juste après est 11,2. La valeur à l'indice 2 est supérieure de plus de 5 unités à ses deux voisines. Il s'agit donc d'un "pic supérieur".
//    Lorsque la différence est exactement de 5, elle peut valider un pic. Par exemple, la valeur à l'indice 6 est de 14,9. La valeur qui la précède est 9,9 et celle qui la suit est 9,4. Il s'agit d'un autre pic supérieur.
//    La valeur à l'indice 9 est 3,1. Ses voisines sont 9,4 et 12,7. La valeur à l'indice 9 est donc un "pic inférieur".

//Dans cet exemple, votre code doit retourner 3.

static int count(List<double> values)
{
    if (values.Count > 20) return 0;

    int firstIndex, secondIndex, thirdIndex;
    double firstValue, secondValue, thirdValue;
    int counter = 0, topPeaks = 0, bottomPeaks = 0;

    for (firstIndex = 0; firstIndex < values.Count - 2; firstIndex++)
    {
        secondIndex = firstIndex + 1;
        thirdIndex = secondIndex + 1;

        firstValue = values[firstIndex];
        secondValue = values[secondIndex];
        thirdValue = values[thirdIndex];

        //testing for Positive increment
        double diffPrev = Math.Round(secondValue - firstValue, 1);
        double diffNext = Math.Round(secondValue - thirdValue, 1);
        //Console.WriteLine($"secondValue: {secondValue} - firstValue: {firstValue}");
        //Console.WriteLine($"thirdValue: {thirdValue}");
        Console.WriteLine($"diffPrev: {diffPrev} - diffNext: {diffNext}");

        if ((diffPrev >= 5) && (diffNext >= 5))
        {
            topPeaks++;
            counter++;
        }
        if ((diffPrev <= -5) && (diffNext <= -5))
        {
            bottomPeaks++;
            counter++;
        }

    }
    Console.WriteLine($"Top Peaks: {topPeaks}- Bottom Peaks: {bottomPeaks} -  Total: {counter} - Total List Elements: {values.Count}");
    return counter;
}
List<double> values = new List<double> { 8, 10.7, 17.1, 11.2, 13.5, 9.9, 14.9, 9.4, 9.4, 3.1, 12.7 };


static int CountPeaks(List<double> values)
{
    int counter = 0;

    for (int i = 1; i < values.Count - 1; i++)
    {
        double prev = values[i - 1];
        double curr = values[i];
        double next = values[i + 1];

        if (curr - prev >= 5 && curr - next >= 5) counter++;        // top peak
        else if (curr - prev <= -5 && curr - next <= -5) counter++; // bottom peak
    }

    return counter;
}
int res = CountPeaks(values);
//Console.WriteLine(res);

//1. Somme des voisins
//Étant donné une liste d’entiers, retourne une nouvelle liste où chaque élément est la somme de ses deux voisins (ignore le premier et le dernier).
//Exemple : [1, 2, 3, 4, 5] → [4, 6, 8]

static List<int> newList(List<int> ints)
{
    List<int> newList = new List<int>();

    int curr, prev, next;
    for (int i = 1; i < ints.Count - 1; i++)
    {
        curr = ints[i];
        next = ints[i + 1];
        prev = ints[i - 1];

        newList.Add(next + prev);
    }
    return newList;
}

List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
//Console.WriteLine(string.Join(", ", newList(ints)));

//
static bool Exists(int[] ints, int k)
{


    int maxSize = 1_000_000;

    if ((ints.Length > maxSize) || (ints.Length <= 0)) { return false; }
    Array.Sort(ints);
    int i = Array.BinarySearch(ints, k);

    return i >= 0 ? true : false;

}
//Stopwatch sw = Stopwatch.StartNew();
//sw.Start();
//int[] ints2 = { 5, -9, 14, 37, 102 };
//Console.WriteLine(Exists(ints2,102));
//Console.WriteLine(Exists(ints2, -9));
//sw.Stop();
//Console.WriteLine($"Execution Time: {sw.ElapsedMilliseconds}ms");
//Console.ReadLine();

//2.Maximum local

//Énoncé : Retourner tous les indices où un élément est strictement supérieur à ses voisins immédiats.
//Exemple : [1, 3, 2, 4, 3] → indices [1, 3]

//reverse order of words in a string
static char[] ReverseAllWords(char[] phrase)
{
    int startInd = 0;
    int endInd = phrase.Length - 1; // Length = number of chars

    char[] reversed = ReverseWord(phrase, startInd, endInd);

    for (int i = 0; i <= reversed.Length; i++)
    {

        if ((i == reversed.Length) || (reversed[i] == ' '))
        {

            reversed = ReverseWord(reversed, startInd, i - 1);

            startInd = i + 1;

        }

    }

    return reversed;
}

static char[] ReverseWord(char[] word, int startInd, int endInd)
{

    char tmpLetter;
    while (startInd < endInd)
    {
        tmpLetter = word[startInd];
        word[startInd++] = word[endInd];
        word[endInd--] = tmpLetter;
    }
    return word;
}

Console.WriteLine(ReverseAllWords("Hello Kitty World".ToCharArray()));