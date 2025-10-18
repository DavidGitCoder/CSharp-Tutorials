using AnonymousMethods;

int aboutToBlowCounter = 0;

Car c1 = new Car("SlugBug", 100, 10);

c1.AboutToBlow += delegate { Console.WriteLine($"Eek! Going to fast!");aboutToBlowCounter++; };

c1.AboutToBlow += delegate (object sender, CarEventArgs e)
{
    Console.WriteLine($"Message from car: {e.msg}"); aboutToBlowCounter++;
};
c1.Exploded += delegate (object sender, CarEventArgs e)
{
    Console.WriteLine($"Fatal msg from car: {e.msg}");
};
for(int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
Console.WriteLine($"AbouttoBlow event was fired {aboutToBlowCounter} times");