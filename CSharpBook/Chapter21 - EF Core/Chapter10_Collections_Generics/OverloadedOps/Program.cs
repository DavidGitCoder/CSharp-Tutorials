using OverloadedOps;

Point p1 = new Point(100, 100);
Point p2 = new Point(40, 40);
Point p3 = p1;
Console.WriteLine($"p1 = {p1}");
Console.WriteLine($"p2 = {p2}");
Console.WriteLine($"p3 = {p3}");

Console.WriteLine($"p1 = p3? {p1==p3}");
p3.X = 20;
p3=new Point(20,100);
Console.WriteLine($"p1 = {p1}");
Console.WriteLine($"p2 = {p2}");
Console.WriteLine($"p3 = {p3}");
Console.WriteLine($"p1 Equals p3? {p1!=p3}");
Console.WriteLine($"p1 Equals p2? {p1==p2}");
Console.WriteLine("\n");
p1 += 50;
Console.WriteLine($"p1 = {p1}");
Console.WriteLine($"p2 = {p2}");
Console.WriteLine($"p1 < p3? {p1 < p3}");
Console.WriteLine($"p1 > p2? {p1 > p2}");
Console.WriteLine("\n");


p1 += 500;
p2-=1;
p2--;
p1++;
Console.WriteLine($"p1 + p2: {p1+p2}");
Console.WriteLine($"p1 - p2: {p1 - p2}");

Console.WriteLine($"p1 + 5: {p1 + 5}");
Console.WriteLine($"3 - p2: {3 - p2}");