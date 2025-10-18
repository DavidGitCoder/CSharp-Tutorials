static void BuildAnonymousType(string make, string color, int currSp)
{
    var car = new {Make=make,Color=color, Speed=currSp};
    Console.WriteLine($"You have a {car.Color} {car.Make} driving at {car.Speed}");
    Console.WriteLine(car);
}

static void ReflectOverAnonymous(object o)
{
    Console.WriteLine(o.GetType().Name);
    Console.WriteLine($"Base class of {o.GetType().Name} is {o.GetType().BaseType}");
    Console.WriteLine(o.ToString());
    Console.WriteLine(o.GetHashCode());
}
BuildAnonymousType("Ford","Black",85);
Console.WriteLine( );
var c = new { Color = "Blue", Make = "Porsche", Speed = 55 };

ReflectOverAnonymous(c);
Console.WriteLine();

var purchaseItem = new
{
    TimeBought = DateTime.Now,
    ItemBought = new { Color = "Red", Make = "Saab", CurrentSpeed = 55 },
    Price = 34.000
};
ReflectOverAnonymous(purchaseItem);