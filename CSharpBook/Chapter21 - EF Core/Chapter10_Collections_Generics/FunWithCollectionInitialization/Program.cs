using System.Collections;
using System.Drawing;

int[] arInt = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
List<int> lInt = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
ArrayList arlInst = new ArrayList() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

List<Point> lPoints = new List<Point>()
{
    new Point{X=2,Y=2},
    new Point{X=3,Y=3},
    new Point{X=4,Y=4}
};
foreach (Point p in lPoints)
{
    Console.WriteLine(p);
}
List<Rectangle> lRectangles = new List<Rectangle>()
{
    new Rectangle{Height=90,Width=90,Location= new Point { X=10, Y=10 } },
    new Rectangle{Height=50,Width=50, Location= new Point { X=1, Y=1 } }

};
foreach(Rectangle r in lRectangles)
{
    Console.WriteLine(r);
}