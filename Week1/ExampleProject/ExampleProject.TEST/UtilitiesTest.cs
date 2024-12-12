//Adding refernce to project to be tested
//dotnet add <location of test csproj> reference <location of app csproj>
using ExampleProject.APP;
using ExampleProject.APP.Util;

namespace ExampleProject.TEST;

public class UtilitiesTest
{
    public static List<int> ReturnLargeList()
    {
        return [4,1,2,3,4,5,10,8,9,10];
    }
    
    [Fact]
    public void IsEvenReturnsTrueWhenNumberIsEven()
    {
        //Arrange
        int number = 98;

        //Act
        bool result = Utilities.IsEven(number);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEvenReturnsFalseWhenNumberIsOdd()
    {
        //Arrange
        int number = 99;

        //Act
        bool result = Utilities.IsEven(number);

        //Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(-2, true)]
    [InlineData(0, true)]
    [InlineData(3, false)]
    [InlineData(100, true)]
    [InlineData(101, false)]
    public void IsEvenDoesTheThing(int n, bool expected)
    {
        //Arrange

        //Act
        bool result = Utilities.IsEven(n);
        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestName()
    {
        //Arrange
        List<Car> carList = [
            new Car{Make = "Toyota", Model = "Camry", MPG = 30},
            new Car{Make = "Toyota", Model = "4Runner", MPG = 20},
            new Car{Make = "Honda", Model = "Civic", MPG = 32},
            new Car{Make = "Mazda", Model = "Mazda6", MPG = 27},
            new Car{Make = "Ferrari", Model = "F1", MPG = 15}
        ];

        Car c = new(){Make = "Masserati", Model = "Coolcar", MPG = 12};

        //Act
        Utilities.AddCar(c, carList);

        //Assert
        Assert.Contains(c, carList);
        Assert.Contains(carList, c => c.Make.Equals("Masserati"));
    }
}