using StudentManagement;

namespace WriteUnitTest.APP;

class Program
{
    static void Main(string[] args)
    {
        var studentService = new StudentService();

        studentService.AddStudent(new Student { Id = 1, Name = "Alice", Age = 20, Grade = 85 });
        studentService.AddStudent(new Student { Id = 2, Name = "Bob", Age = 22, Grade = 90 });
        studentService.AddStudent(new Student { Id = 3, Name = "Charlie", Age = 19, Grade = 70 });

        Console.WriteLine("All Students:");
        foreach (var student in studentService.GetAllStudents())
        {
            Console.WriteLine($"{student.Id}: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }

        Console.WriteLine($"\nAverage Grade: {studentService.CalculateAverageGrade()}");
    }
}
