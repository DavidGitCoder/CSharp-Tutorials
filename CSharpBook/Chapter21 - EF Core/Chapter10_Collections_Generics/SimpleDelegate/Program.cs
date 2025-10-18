using SimpleDelegate;

Car c = new Car("Buzz", 80, 50);

c.RegisterWithCarEngine(OnCarEngineEvent);
c.RegisterWithCarEngine(OnCarEngineEvent2);

Console.WriteLine("**** Speeding up ****");
for(int i = 0; i < 6; i++)
{
    c.Accelerate(10);
}
c.UnregisterWithCarEngine(OnCarEngineEvent2);
for (int i = 0; i < 6; i++)
{
    c.Accelerate(10);
}
static void OnCarEngineEvent(string msg)
{
    Console.WriteLine("\n*** Message From Car Object ***");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("********************\n");
}
static void OnCarEngineEvent2(string msg)
{
    Console.WriteLine("=> {0}", msg.ToUpper());
}

