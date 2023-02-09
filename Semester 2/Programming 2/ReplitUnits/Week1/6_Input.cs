namespace ReplitUnits.Week1;

public class Input {
    public static void Main_input()
    {
        Console.WriteLine("Please enter your name >>>");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your age >>>");
        string age = Console.ReadLine();
        Console.WriteLine("Hello " + name + ", You are " + age + " years old!");
    }
}