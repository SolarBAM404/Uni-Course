namespace ReplitUnits.Week3;

public class IfElse
{
    public static void Main()
    {
        Console.WriteLine("Please enter a whole number: ");
        string numberStr = Console.ReadLine();
        int number = int.Parse(numberStr);
        switch (number % 2)
        {
            case 1:
                Console.WriteLine("Your number is odd");
                break;
            case 0:
                Console.WriteLine("Your number is even");
                break;
        }
    }
}