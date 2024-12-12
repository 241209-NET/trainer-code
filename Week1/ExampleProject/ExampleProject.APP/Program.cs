using ExampleProject.APP.Util;

namespace ExampleProject.APP;

class Program
{
    static void Main(string[] args)
    {
        bool isEven = Utilities.IsEven(45);
        Console.WriteLine(isEven);
    }
}