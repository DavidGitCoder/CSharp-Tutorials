using RecordInheritance;

Car c = new Car("Honda", "Pilot", "Blue");
MiniVan m = new MiniVan("Honda","Pilot","Blue", 10);
Console.WriteLine($"Cheching MiniVan is-a Car:{m is Car}");

MotorCycle mc = new MotorCycle("Harley", "Bardot Edition");
Console.WriteLine(mc);
FancyScooter fs = new FancyScooter("Vespa", "1964", "BlueCaraibean");
Console.WriteLine(fs);
Console.WriteLine(fs is MotorCycle);