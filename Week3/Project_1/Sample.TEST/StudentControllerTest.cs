using Moq;
using Sample.API.Repository;
using Sample.API.Service;

namespace Sample.TEST;

public class StudentControllerTest
{
    // [Theory]
    // [InlineData(1, false)]
    // //[InlineData(2, true)]
    // [InlineData(3, false)]
    // //[InlineData(4, true)]
    // [InlineData(5, false)]
    // public void IsEvenReturnsCorrectly(int n, bool expected)
    // {
    //     //Arrange
    //     Mock<IStudentRepository> mockRepo = new();
    //     StudentService studentService = new(mockRepo.Object);
    //     //Act
    //     bool result = studentService.IsEven(n);
    //     //Assert
    //     Assert.Equal(expected, result);
    // }

    [Fact]
    public void IsEvenReturnsCorrectly2()
    {
        //Arrange
        Mock<IStudentRepository> mockRepo = new();
        StudentService studentService = new(mockRepo.Object);
        //Act
        bool result = studentService.IsEven(2);
        //Assert
        Assert.True(result);
    }
}