namespace StrategyPatternDemo.ConsoleApp.Movies;

public class Inception
{
    public string Title => "Inception";
    public string Description => "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.";
    public DateTime ReleaseDate => new(2010, 06, 22);

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
