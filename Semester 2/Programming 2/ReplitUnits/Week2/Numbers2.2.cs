namespace DefaultNamespace;

public class Numbers2_2
{
    public static void Main()
    {
        Console.WriteLine("Please input value a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input value b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please input value c");
        float c = float.Parse(Console.ReadLine());
        
        Console.WriteLine((10.3 + 5).GetType());
        Console.WriteLine(a + b * c);
        Console.WriteLine(a + b / c);
        double result_c = Math.Pow(c, c);
        Console.WriteLine(result_c);
        double result_floor = Math.Floor(a * b * c);
        Console.WriteLine(result_floor);
        Console.WriteLine(a < b);
        Console.WriteLine((a < b) == (a <= c));
    }
}