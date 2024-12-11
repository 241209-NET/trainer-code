using System.Text.Json;

namespace DailyTasks.Util;


public class Utilities
{
    public static int UserChoice(string? choice)
    {
        try
        {
            return Convert.ToInt32(choice);
        } catch(Exception)
        {
            Console.WriteLine("Invalid choice!");
            return -1;
        }
    }

    public static List<Assignment> LoadTasks(string fileName)
    {
        try{
            using(StreamReader sr = new(fileName))
            {
                string? json = sr.ReadLine();

                if(json is not null) return JsonSerializer.Deserialize<List<Assignment>>(json)!;

                return [];
            }
        } catch(Exception)
        {
            return [];
        }        
    }

    public static void SaveTasks(List<Assignment> assignments, string fileName)
    {
        StreamWriter output = new StreamWriter(fileName);
        output.WriteLine(JsonSerializer.Serialize(assignments));
        output.Close();
    }
}