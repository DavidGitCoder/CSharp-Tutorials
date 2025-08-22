//Get arguments using System.Environment
string[] theArgs=Environment.GetCommandLineArgs();

//Display a simple message to the user.
Console.WriteLine("***** My First C# App *****");
Console.WriteLine("Hello, World!");
Console.WriteLine();


// Process any incoming args.
foreach (string arg in theArgs)
{
    Console.WriteLine("Arg: {0}", arg);
    if (arg=="-godmode")
    {
        Console.WriteLine("You're a cheater!! mwahaha!");
    }
    
}

// Local method within the Top-level statements
ShowEnvironmentDetails();

// Wait for Enter key to be pressed before shutting down.
Console.ReadLine();
// Return the arbitrary error code.
return 0;

static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other interesting details
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}", Environment.Version);
    Console.WriteLine("System Directory:{0}", Environment.SystemDirectory);
}
