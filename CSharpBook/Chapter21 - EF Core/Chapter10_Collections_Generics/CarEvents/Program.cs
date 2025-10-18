using CarEvents;
using System.Security.Cryptography;

Car myCar=new Car("Beeetle", 100, 10);
myCar.AboutToBlow += CarIsAlmostDoomed;
myCar.AboutToBlow += CarAboutToBlow;

EventHandler<CarEventArgs> d = CarExploded;
myCar.Exploded += d;

for (int i = 0; i < 6; i++)
{
    myCar.Accelerate(20);
}
myCar.Exploded -= d;

Console.WriteLine("\n***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    myCar.Accelerate(20);
}
Console.ReadLine();

static void CarAboutToBlow(object sender, CarEventArgs e) { Console.WriteLine($"{((Car)sender).PetName}: {e.msg}"); }
static void CarIsAlmostDoomed(object sender, CarEventArgs e) { Console.WriteLine($"Critical msg from car: {sender} says {e.msg}"); }
static void CarExploded(object sender, CarEventArgs e)
{
    Console.WriteLine($"EXPLOSION!!! {sender}: {e.msg}");
}