using ComparableCar;

Car[] autos = new Car[5];
autos[0] = new Car("Rusty",80,1);
autos[1] = new Car("Debbie", 50, 113);
autos[2] = new Car("McLane", 35, 20);
autos[3] = new Car("Stu", 65, 5);
autos[4] = new Car("Addie", 70, 7);
foreach (Car c in autos)
{
    Console.WriteLine(c);
}

Console.WriteLine();

Array.Sort(autos,Car.SortByPetName);

foreach(Car c in autos)
{
    Console.WriteLine(c);
}

