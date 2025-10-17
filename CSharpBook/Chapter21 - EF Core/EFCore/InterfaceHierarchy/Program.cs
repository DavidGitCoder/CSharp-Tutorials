using InterfaceHierarchy;

BitmapImage b = new BitmapImage();
b.Draw();
b.DrawInBoundingBox(10,10,100,150);
b.DrawUpsideDown();
Console.WriteLine(b.TimeToDraw());
Console.WriteLine(((IDrawable)b).TimeToDraw());
Console.WriteLine(((IAdvancedDraw)b).TimeToDraw());

//if(b is IAdvancedDraw i)
//{
//    i.DrawUpsideDown();
//    Console.WriteLine($"Time to draw: {i.TimeToDraw()}");

//}