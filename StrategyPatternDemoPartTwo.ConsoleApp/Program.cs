using StrategyPatternDemoPartTwo.ConsoleApp.Movies;

Console.WriteLine("Type the name of the movie you want to get information about:");
Console.WriteLine("Shrek");
Console.WriteLine("Inception");
Console.WriteLine("The Matrix");
Console.WriteLine("");
Console.Write("Type here: ");
string? name = Console.ReadLine();

if (name == "Shrek")
{
    Shrek shrek = new();
    Console.WriteLine(shrek.Title);
    Console.WriteLine(shrek.Description);
    Console.WriteLine($"{shrek.ReleaseDate} ({shrek.Age()} years old)");
}
else if (name == "Inception")
{
    Inception inception = new();
    Console.WriteLine(inception.Title);
    Console.WriteLine(inception.Description);
    Console.WriteLine($"{inception.ReleaseDate} ({inception.Age()} years old)");
}
else if (name == "The Matrix")
{
    TheMatrix theMatrix = new();
    Console.WriteLine(theMatrix.Title);
    Console.WriteLine(theMatrix.Description);
    Console.WriteLine($"{theMatrix.ReleaseDate} ({theMatrix.Age()} years old)");
}
else
{
    Console.WriteLine("Movie not found! Crashing now.");
}