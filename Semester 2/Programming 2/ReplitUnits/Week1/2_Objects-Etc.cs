namespace ReplitUnits.Week1;

public class Objects_Etc
{
    public static void Main_objects()
    {

        int output1 = (12 + 5);
      
        Console.WriteLine("My data is...");
        Console.WriteLine(output1.ToString());
        Console.WriteLine("My type is...");
        Console.WriteLine(output1.GetType());

        double output2 = (5 + 3.0);
        Console.WriteLine("My data is...");
        Console.WriteLine(output2.ToString());
        Console.WriteLine("My type is...");
        Console.WriteLine(output2.GetType());
      
        double output3 = (12 / 5);
        Console.WriteLine("My data is...");
        Console.WriteLine(output3.ToString());
        Console.WriteLine("My type is...");
        Console.WriteLine(output3.GetType());

      
        bool output4 = (1300 + 37 == 23 * 3.147);
        Console.WriteLine("My data is...");
        Console.WriteLine(output4.ToString());
        Console.WriteLine("My type is...");
        Console.WriteLine(output4.GetType());
    }
}