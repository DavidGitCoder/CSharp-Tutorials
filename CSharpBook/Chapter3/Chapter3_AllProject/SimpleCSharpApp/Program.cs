
//Display a simple message to the user.
Console.WriteLine("***** My First C# App *****");
Console.WriteLine("Hello, World!");
Console.WriteLine();
// Process any incoming args.
for(int i = 0;i<args.Length;i++)
{
    Console.WriteLine("Arg: {0}", args[i]);
}
// Wait for Enter key to be pressed before shutting down.
Console.ReadLine();
// Return the arbitrary error code.
return 0;
