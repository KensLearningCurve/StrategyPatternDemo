using StrategyPatternDemo.ConsoleApp.Movies;

Shrek shrek = new();
Console.WriteLine(shrek.Title);
Console.WriteLine(shrek.Description);
Console.WriteLine($"{shrek.ReleaseDate} ({shrek.Age()} years old)");
Console.WriteLine("-----------------------------------------------------");

TheMatrix theMatrix = new();
Console.WriteLine(theMatrix.Title);
Console.WriteLine(theMatrix.Description);
Console.WriteLine($"{theMatrix.ReleaseDate} ({theMatrix.Age()} years old)");
Console.WriteLine("-----------------------------------------------------");

Inception inception = new();
Console.WriteLine(inception.Title);
Console.WriteLine(inception.Description);
Console.WriteLine($"{inception.ReleaseDate} ({inception.Age()} years old)");
Console.WriteLine("-----------------------------------------------------");