using FunWithRecords;

Console.WriteLine("*************** RECORDS *********************");
//Use object initialization
CarRecord myCarRecord = new ("Honda","Pilot","Blue");
Console.WriteLine("My car: ");
DisplayCarRecordStats(myCarRecord);
var (a, b,c) = myCarRecord;
Console.WriteLine((a,b,c));
Console.WriteLine();
//Use the custom constructor
CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
Console.WriteLine(anotherMyCarRecord.ToString());
Console.WriteLine();
Console.WriteLine($"Cars are the same? {myCarRecord.Equals(anotherMyCarRecord)}");
Console.WriteLine($"Cars are the same reference? {ReferenceEquals(myCarRecord, anotherMyCarRecord)}");
CarRecord ourOtherCar = myCarRecord with { Model = "Odyssey" };
Console.WriteLine("My copied car:");
Console.WriteLine(ourOtherCar.ToString());
Console.WriteLine("Car Record copy using with expression results");
Console.WriteLine($"CarRecords are the same? {ourOtherCar.Equals(myCarRecord)}");
Console.WriteLine($"CarRecords are the same? {ReferenceEquals(ourOtherCar, myCarRecord)}");
Console.ReadLine();
static void DisplayCarRecordStats(CarRecord c)
{
    Console.WriteLine("Car Make: {0}", c.Make);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}