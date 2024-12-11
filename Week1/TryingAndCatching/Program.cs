namespace TryingAndCatching;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");

        string? input = Console.ReadLine();

        if(int.TryParse(input, out int num))
        {
            Console.WriteLine($"The number you entered was: {num}");
        }
        else Console.WriteLine("You done goofed");

        // try
        // {
        //     int num = int.Parse(input!);
        //     Console.WriteLine($"The number you entered was: {num}");
        // }
        // catch(ArgumentNullException)
        // {
            
        //     Console.WriteLine("Input cannot be null.");
        // }
        // catch(FormatException)
        // {
        //     Console.WriteLine("Input can only have numbers.");
        // }
        // catch(OverflowException)
        // {
        //     Console.WriteLine("Input is too large.");
        // }
        // finally
        // {
        //     Console.WriteLine("You get 1 last try, enter a number.");
        //     int num = int.Parse(Console.ReadLine()!);
        //     Console.WriteLine($"The number you entered was: {num}");
        // }
        Console.WriteLine("This is the end.");
    }
}
