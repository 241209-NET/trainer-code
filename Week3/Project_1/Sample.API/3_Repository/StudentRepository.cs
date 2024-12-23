using Sample.API.Data;

namespace Sample.API.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly SampleContext _sampleContext;

    public StudentRepository(SampleContext sampleContext) => _sampleContext = sampleContext;

    //Start wiritng Repo CRUDs
}