using DailyTasks.Util;

namespace DailyTasks;

class Program
{
    static void Main(string[] args)
    {
        string saveFile = "tasksave.json";

        List<Assignment> myAssign = Utilities.LoadTasks(saveFile);
        
        while(true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Display All Tasks");
            Console.WriteLine("3. Exit");

            int userChoice = Utilities.UserChoice(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    Assignment newTask = Assignment.MakeNewTask();
                    Assignment.AddAssignmentToList(newTask, myAssign);
                    break;
                case 2:
                    foreach(var a in myAssign)
                    {
                        Console.WriteLine(a);
                    }
                    break;
                case 3:
                    Utilities.SaveTasks(myAssign, saveFile);
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        
    }
}
