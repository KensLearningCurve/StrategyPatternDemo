namespace StrategyPatternDemo.ConsoleApp.Movies;

public class TheMatrix
{
    public string Title => "The Matrix";
    public string Description => "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.";
    public DateTime ReleaseDate => new(1999, 06, 17);

    public int Age()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - ReleaseDate.Year;

        if (currentDate < ReleaseDate.AddYears(age))
        {
            age--;
        }

        return age;
    }
}
