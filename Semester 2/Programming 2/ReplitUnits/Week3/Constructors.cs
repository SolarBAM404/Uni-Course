namespace ReplitUnits.Week3;

public class Constructors
{
    public static void Main()
    {
        Adventurer adventurer = new("Rick", 120, 30);
        adventurer.Introduction();
        adventurer.Description();
        adventurer.SayGold();

        Adventurer adventurer2 = new("David", 150, 10, 2, 480);
        adventurer2.Introduction();
        adventurer2.Description();
        adventurer2.SayGold();
    } 
}

