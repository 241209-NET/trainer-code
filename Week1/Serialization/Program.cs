using System.Text.Json;

namespace Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<Movie> movieList = [];

        using(StreamReader sr = new("movies.json"))
        {
            while(sr.Peek() != -1)
            {
                string? s = sr.ReadLine();
                if(s is not null)
                {
                    movieList = JsonSerializer.Deserialize<List<Movie>>(s)!;
                }
            }
        }

        foreach(var mov in movieList)
        {
            Console.WriteLine(mov.Name);
        }

        while(true)
        {
            string s = Console.ReadLine()!;
            if(s.Equals("!")) break;
            Movie newMov = new(){Name = s};
            movieList.Add(newMov);
        }

        Console.WriteLine("\n\n\n");

        string jsonString = JsonSerializer.Serialize(movieList);
        Console.WriteLine(jsonString);
        using(StreamWriter sw = new("movies.json"))
        {
            sw.WriteLine(jsonString);
        }
    }
}