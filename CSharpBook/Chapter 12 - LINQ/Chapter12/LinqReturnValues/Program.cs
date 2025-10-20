IEnumerable<string> subset = GetStringSubset();
foreach (string subsetEntry in subset)
{
    Console.WriteLine(subsetEntry);
}
subset=GetStringSubsetAsArray();

foreach (string subsetEntry in subset)
{
    Console.WriteLine(subsetEntry);
}
static IEnumerable<string> GetStringSubset()
{
    string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };
    IEnumerable<string> theRedColord=from c in colors where c.Contains("Red") select c;
    return theRedColord;
}
static string[] GetStringSubsetAsArray()
{
    string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };
    IEnumerable<string> theRedColord = from c in colors where c.Contains("Red") select c;
    return theRedColord.ToArray<string>();
}