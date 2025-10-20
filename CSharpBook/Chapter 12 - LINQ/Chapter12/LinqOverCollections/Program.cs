using LinqOverCollections;

List<Car> cars = new List<Car>()
{
    //Object Initialization Syntax
    new Car{PetName="Rusty", Make="Ford", Color="Red", Speed=90 },
    new Car{PetName="Clunker", Make="Ford", Color="Dark Blue", Speed=45 },
    new Car{PetName="Daisy", Make="Mustang", Color="Pink", Speed=70 },
    new Car{PetName="Clunker", Make="VW", Color="Rust", Speed=5 },
    new Car{PetName="Melvin", Make="Pontiac", Color="Black", Speed=100 }
};
var fastCars = from car in cars where car.Speed>55 && car.Make=="Ford" select car;

foreach (var car in fastCars)
{
    Console.WriteLine($"{car.PetName} is going too fast!");
}
