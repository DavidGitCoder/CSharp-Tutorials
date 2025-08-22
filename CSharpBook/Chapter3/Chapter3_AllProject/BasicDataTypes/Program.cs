using System.Numerics;

Console.WriteLine("***** Fun with Basic Data Types *****");

LocalVarDeclarations();

static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declaration:");
    // Local variables are declared as so;
    // dataType varName;
    int myInt=0;

    // You can declare and assign on two lines
    string myString;
    myString = "This is my character data";

    // Declare 3 bools on a single line
    bool b1 = true, b2 = false, b3 = b1;

    //Use System.Boolean data type to declare a bool.
    System.Boolean b4 = false;

    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
    Console.WriteLine();

}