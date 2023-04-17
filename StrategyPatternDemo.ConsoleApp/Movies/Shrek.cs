namespace StrategyPatternDemo.ConsoleApp.Movies;

public class Shrek
{
    public string Title => "Shrek";
    public string Description => "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.";
    public DateTime ReleaseDate => new(2001, 07, 12);

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
