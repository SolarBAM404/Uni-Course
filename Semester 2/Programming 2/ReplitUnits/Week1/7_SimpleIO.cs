namespace ReplitUnits.Week1;

public class SimpleIO {
    public static void Main_simpleIO () {
        Console.WriteLine("Please enter a whole number:");
        String numberStr = Console.ReadLine();
        int numberInt = Int16.Parse(numberStr);
        Console.WriteLine($"{numberStr}x10 = {numberInt * 10}");
    }
}