using StudentManagement;

namespace WriteUnitTest.TEST;

public class StudentServiceTest
{
    [Fact]
    public void IsStudentGradeNegative()
    {
        StudentService studentService = new StudentService();
        Student student = new Student();
        student.Grade = -100.00;
        student.Name = "Kung";
        student.Age = 32;

        var exception = Assert.Throws<ArgumentException>(() => studentService.AddStudent(student));

        Assert.Equal("Student grade cannot be less than 0", exception.Message);
    }
    
    [Fact]
    public void TestGetStudentId()
    {
        StudentService studentService = new StudentService();
        Student student = new Student();
        student.Id = 2;
        student.Grade = 86.00;
        student.Name = "Kung";
        student.Age = 32;
        studentService.AddStudent(student);
        
        Student? student2 = studentService.GetStudentById(2);

        Assert.NotNull(student2);
        Assert.Equal(student.Id, student2.Id);
    }
    
    [Fact]
    public void AverageStudentGradeTest()
    {
        //Arrange
        StudentService _studentService = new StudentService();
        var students = new List<Student> 
        {
            new Student {Id = 1, Name = "test1", Age = 20, Grade = 70},
            new Student {Id = 2, Name = "test1", Age = 21, Grade = 80},
            new Student {Id = 3, Name = "test1", Age = 22, Grade = 90},
        };

        foreach (var student in students)
        {
            _studentService.AddStudent(student);
        }
        double testAverage = 80;
        //Act
        double result = _studentService.CalculateAverageGrade();    
        
        //Assert 
        Assert.Equal(testAverage, result);    
    }

    [Fact]
    public void AddStudentTestNameIsNull_Fail(){
        List<Student> _students = [];
        Student student = new Student(){Id = 1, Name = null, Age = 10, Grade = 80 };
        StudentService srvTest = new();
        
        Assert.Throws<ArgumentException>(
            () => srvTest.AddStudent(student)
        );
    }

    [Theory]
    [InlineData("Two White Spaces")]
    [InlineData("One Whitespace")]
    [InlineData("No_Whitespace")]
    public void AddStudentTestContainsWhiteSpace(String studentName)
    {
        StudentService studentService = new StudentService();
        Student student = new Student();
        student.Name = studentName;
        student.Age = 10;
        student.Grade = 100;

        var exception = Record.Exception(() => studentService.AddStudent(student));
        Assert.Null(exception);
    }
    
    [Fact]
    public void AddStudentTestNameIsNotNull_Pass(){
        Student student = new Student(){Id = 1, Name = "someName", Age = 10, Grade = 80 };
        StudentService srvTest = new();
        
        srvTest.AddStudent(student);
        var _students = srvTest.GetAllStudents();
        
        Assert.Contains( student, _students);
    }
}