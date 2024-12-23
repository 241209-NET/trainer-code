using Sample.API.Repository;

namespace Sample.API.Service;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository) => _studentRepository = studentRepository;

    public bool IsEven(int n) => n % 2 == 0;
}