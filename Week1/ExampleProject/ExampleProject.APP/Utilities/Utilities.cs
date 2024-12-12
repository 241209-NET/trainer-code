namespace ExampleProject.APP.Util;

public static class Utilities
{
    public static bool IsEven(int n) => n % 2 == 0;

    public static string SayHello()
    {
        return "Hello, welcome to my application!";
    }

    public static void AddCar(Car c, List<Car> carList)
    {
        carList.Add(c);
    }
}