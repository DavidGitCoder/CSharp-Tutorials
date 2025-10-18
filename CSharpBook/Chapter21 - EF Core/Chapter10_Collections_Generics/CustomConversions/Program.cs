using CustomConversions;
using System.Runtime.Intrinsics.Arm;

Rectangle r = new Rectangle() { Height=10, Width=20};
Console.WriteLine(r.ToString());
r.Draw();

Square s = new Square() { Length=5};
Console.WriteLine(s.ToString());
s.Draw();

Square s2 = (Square)r;
Console.WriteLine(s2.ToString());
s2.Draw();

Square s3 = (Square)4;
Console.WriteLine(s3.ToString());
s3.Draw();

int length = (int)s;
Console.WriteLine(length);

Rectangle r2 = s;
Console.WriteLine(r2.ToString());
r2.Draw();