namespace LinqDemo;

class Program
{
    static void Main(string[] args)
    {
        Car c1 = new(){Make = "Toyota", Model = "Camry", MPG = 30};
        Car c2 = new(){Make = "Toyota", Model = "4Runner", MPG = 20};
        Car c3 = new(){Make = "Honda", Model = "Civic", MPG = 32};
        Car c4 = new(){Make = "Mazda", Model = "Mazda6", MPG = 27};
        Car c5 = new(){Make = "Ferrari", Model = "F1", MPG = 15};

        List<Car> carList = [c1, c2, c3, c4, c5];

        //Classic Way to filter a list
        // List<Car> WantToBuy = [];

        // foreach(Car c in carList)
        // {
        //     if(c.MPG >= 25) WantToBuy.Add(c);
        // }

        // foreach(Car c in WantToBuy)
        // {
        //     Console.WriteLine(c);
        // }

        // //Using linq
        // var WantToBuyLinq =         
        //     from car in carList
        //     where car.MPG >= 25
        //     select car;

        // //Console.WriteLine(WantToBuyLinq);

        // foreach(Car c in WantToBuyLinq)
        // {
        //     Console.WriteLine(c);
        // }

        List<Car> WantToBuyLinq2 = carList
            .Where(c => c.MPG >= 25 && c.Model.Contains('C'))
            .ToList();

        foreach(Car c in WantToBuyLinq2)
        {
            Console.WriteLine(c);
        }

        int total = carList.Sum(c => c.MPG);
        Console.WriteLine(total);

        double avg = carList.Average(c => c.MPG);
        Console.WriteLine(avg);

        int numOfCars = carList.Count(c => c.Make.ToLower().Contains('a'));
        Console.WriteLine(numOfCars);
    }
}

public class Car
{
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public int MPG { get; set; }

    public override string ToString()
    {
        return $"{Make}, {Model}, {MPG}";
    }
}
