using Shapes;

Shape[] myShapes = [new ThreeDCircle(), new Hexagon(),new Circle("Pedro"), new Hexagon("Angelina"), new Circle("Carlos"), new Hexagon("Betty"), new Circle() 
    , new ThreeDCircle()];
foreach(Shape s in myShapes)
{
    s.Draw();
}
ThreeDCircle myCircle = new ThreeDCircle();
myCircle.Draw();
((Circle)myCircle).Draw();
Console.ReadLine();