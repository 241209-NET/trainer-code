namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Car myCar1 = new("Toyota");
        Car myCar2 = new("Toyota", "Camry", "Red", 100.0);

        Console.WriteLine(myCar1.Getmake());
        Console.WriteLine(myCar1.Getmodel());
        Console.WriteLine(myCar1.Getcolor());
        Console.WriteLine(myCar1.Getspeed());

        Console.WriteLine(myCar2.Getmake());
        Console.WriteLine(myCar2.Getmodel());
        Console.WriteLine(myCar2.Getcolor());
        Console.WriteLine(myCar2.Getspeed());
    }
}

public class Car
{
    //Attributes or fields
    private string _make = "Ferrari";
    private string _model = "F1";
    private string _color = "Null";
    private double _speed = 10.0;
    
    public Car(string make)
    {
        _make = make;
    }

    public Car(string make, string model, string color, double speed)
    {
        _make = make;
        _model = model;
        _color = color;
        _speed = speed;
    }

    //Behaviors or Methods
    public void Setcolor(string color)
    {
        if(color.ToLower().Equals("purple")) _color = "White";
        else _color = color;
    }

    public void Setspeed(double speed) => _speed = speed;

    public string Getmake() => _make;
    public string Getmodel() => _model;
    public string Getcolor() => _color;
    public double Getspeed() => _speed;
}
