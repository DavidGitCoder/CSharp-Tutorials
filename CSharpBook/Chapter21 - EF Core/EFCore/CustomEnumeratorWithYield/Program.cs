using CustomEnumeratorWithYield;
using System.Collections;

Garage carLot = new Garage();
//IEnumerator i=carLot.GetEnumerator();
foreach (Car c in carLot)
{
    Console.WriteLine($"{c.PetName}");
}
carLot.GetTheCars(false);
foreach( Car c in carLot.GetTheCars(true))
{
    Console.WriteLine($"{c.PetName}");
}