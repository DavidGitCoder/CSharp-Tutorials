using GenericPoint;

Point<int> p1=new Point<int>(4,5);
Point<double> p2 = new Point<double>(1.6, 9.3);
Point<string> p3 = new Point<string>("22", "7");

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
//p1.ResetPoint();
//p2.ResetPoint();
//p3.ResetPoint();
//Console.WriteLine(p1);
//Console.WriteLine(p2);
//Console.WriteLine(p3);

PatternMatching(p1);
PatternMatching(p2);
PatternMatching(p3);
static void PatternMatching<T>(Point<T> p)
{
    switch (p)
    {
        case Point<string> pString : Console.WriteLine("Point is based on string");
            return;
        case Point<int> pInt: Console.WriteLine("Point is based on int");
            return;
        case Point<double> pD:
            Console.WriteLine("Point is based on double");
            return;
    }
}