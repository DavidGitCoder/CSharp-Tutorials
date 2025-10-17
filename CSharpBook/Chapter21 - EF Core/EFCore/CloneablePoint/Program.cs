using CloneablePoint;

Point p1 = new Point(10, 50,"Giselle");
Point p2 = (Point)p1.Clone();
p2.X = 44;
Console.WriteLine($"{p1}");
Console.WriteLine($"{p2}");
p2.Description.PetName = "Bobby";
p2.Y = 90;
Console.WriteLine($"{p1}");
Console.WriteLine($"{p2}");