namespace ReplitUnits.Week1;

public class Ex2 {
    public static void Main_ex2 () {
        void ToConsole(String msg) {
            Console.WriteLine(msg);
        }

        ToConsole("Please enter the number of gold pieces:");
        int goldPieces = Int16.Parse(Console.ReadLine());
        ToConsole("Please enter the exchange rate:");
        int exRate = Int16.Parse(Console.ReadLine());

        ToConsole($"{goldPieces} gold pieces are equivalent to {goldPieces * exRate} silver pieces.");
    }
}