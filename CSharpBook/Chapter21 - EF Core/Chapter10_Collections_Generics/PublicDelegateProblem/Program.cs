using PublicDelegateProblem;
using System.ComponentModel.DataAnnotations;

Car c = new Car();
c.ListOfHandlers = Display;
c.Accelerate(10);
c.ListOfHandlers = CallHereToo;
c.Accelerate(4);
c.ListOfHandlers.Invoke("hee, hee, hee");


static void Display(string msg)
{
    Console.WriteLine(msg);
}
static void CallHereToo(string msg)
{
    Console.WriteLine("call here :" + msg);
}