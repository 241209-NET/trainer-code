namespace FileIO;

class Program
{
    static void Main(string[] args)
    {
        string filename = "example.txt";

        Console.WriteLine(WriteFile(filename, "Hello, world", false));
        
        Console.WriteLine(ReadFile(filename));

        string s = "This is some more text";

        Console.WriteLine(WriteFile(filename, s, true));

        Console.WriteLine(ReadFile(filename));
    }

    public static string ReadFile(string filename)
    {
        using(StreamReader sr = new(filename))
        {
            return sr.ReadToEnd();
        }        
    }

    public static string WriteFile(string filename, string text, bool doAppend)
    {
        using(StreamWriter sw = new(filename, append: doAppend))
        {
            sw.WriteLine(text);
        }

        return "Write successful.";
    }
}
