using CustomEnumerator;
using System.Collections;

Garage carLot = new Garage();

foreach (Car c in carLot)
{
    Console.WriteLine($"{c.PetName} is going at {c.CurrentSpeed} MPH");
}
IEnumerator carEnumerator=carLot.GetEnumerator();
carEnumerator.MoveNext();
Car myCar = (Car)carEnumerator.Current;
Console.WriteLine($"{myCar.PetName} is going at {myCar.CurrentSpeed} MPH");
