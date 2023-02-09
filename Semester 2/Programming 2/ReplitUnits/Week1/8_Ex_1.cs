namespace ReplitUnits.Week1;

public class Ex1 {
    public static void Main_ex1()
    {
        //Code goes here!
        string now = DateTime.Now.ToString();

        void ToConsole(String msg) {
            Console.WriteLine(msg);
        }

        ToConsole("Hello and Welcome to Programming in C#.\n");
        ToConsole("C# is an amazing language used in many " +
                  "different ways to develop powerful applications.\n");
        ToConsole($"The current date and time is {now}");
      
    }
}