namespace DailyTasks;

public class Assignment
{
    public string Name { get;set; } = "Task";
    public DateOnly DueDate { get;set; } = DateOnly.FromDateTime(DateTime.Today);
    public string Description { get;set; } = "My Assignmnet";

    public static Assignment MakeNewTask()
    {
        Console.Write("Name: ");
        string? name = Console.ReadLine();
        Console.Write("Due Date: ");
        DateOnly date = DateOnly.Parse(Console.ReadLine()!);
        Console.Write("Desc: ");
        string? desc = Console.ReadLine();

        return new Assignment{Name = name!, DueDate = date, Description = desc!};
    }

    public static void AddAssignmentToList(Assignment task, List<Assignment> taskList)
    {
        taskList.Add(task);
    }

    public override string ToString()
    {
        return $"{Name} {DueDate} {Description}";
    }
}