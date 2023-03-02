namespace ReplitUnits.Week3;

public class Static
{
    public static void Main()
    {
        Adventurer adventurer = new("Rick", 120, 30);

        Adventurer adventurer2 = new("David", 150, 10, 2, 480);
        
        Console.WriteLine("There are {0} adventures in the guild!", Adventurer.GetNumberOfAdventures());
    } 
}