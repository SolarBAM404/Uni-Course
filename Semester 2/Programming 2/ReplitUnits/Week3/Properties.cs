namespace ReplitUnits.Week3;

public class Properties
{
    public static void Main()
    {
        Adventurer adventurer = new("Rick", 120, 30);
        Console.WriteLine("Copper: {0} | Silver: {1} | Gold: {2}", adventurer.Copper, adventurer.Silver, adventurer.Gold);

        adventurer.Copper = 10;
        adventurer.Silver = 25;
        adventurer.Gold = 125;
        
        Console.WriteLine("Copper: {0} | Silver: {1} | Gold: {2}", adventurer.Copper, adventurer.Silver, adventurer.Gold);
    } 
}