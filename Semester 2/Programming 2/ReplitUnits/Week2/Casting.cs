namespace DefaultNamespace;

public class Casting
{
    public static void Main()
    {
        Console.WriteLine("Enter your weight in kg");
        int weight = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your height in metres");
        int height = int.Parse(Console.ReadLine());
        double bmi = weight / (Math.Pow(height, 2));
        Console.WriteLine("Your BMI: {0}", bmi);
    }
}