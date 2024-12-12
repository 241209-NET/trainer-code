namespace StudentManagement;

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }
}

 // Service to manage students
public class StudentService
{
    private readonly List<Student> _students = [];

    // Add a new student
    public void AddStudent(Student student)
    {
        ArgumentNullException.ThrowIfNull(student);
        if (string.IsNullOrWhiteSpace(student.Name))
            throw new ArgumentException("Student name cannot be empty.");
        if (student.Age < 5)
            throw new ArgumentException("Student age must be at least 5.");
        if (student.Grade < 0)
            throw new ArgumentException("Student grade cannot be less than 0");

        _students.Add(student);
    }

    // Get all students
    public List<Student> GetAllStudents()
    {
        return _students.ToList();
    }

    // Find student by ID
    public Student? GetStudentById(int id)
    {
        return _students.FirstOrDefault(s => s.Id == id);
    }

    // Calculate average grade
    public double CalculateAverageGrade()
    {
        if (!_students.Any())
            return 0;

        return _students.Average(s => s.Grade);
    }
}