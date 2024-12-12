namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        //Animal myAni = new();
        Dog myDog = new(){Name = "Rover"};

        IVehicle myPlane1 = new Plane();
        IVehicle myTrain1 = new Train();
        Plane myPlane2 = new();
        Train myTrain2 = new();

        Console.WriteLine(Method(myPlane1));
        Console.WriteLine(Method(myPlane2));
        Console.WriteLine(Method(myTrain1));
        Console.WriteLine(Method(myTrain2));

        //Will not work
        //List<Plane> planeList = [myPlane1, myPlane2];

        List<IVehicle> vList = [myPlane1, myPlane2, myTrain1, myTrain2];

        foreach(IVehicle v in vList)
        {
            Console.WriteLine(Method(v));
        }

        Console.WriteLine(myDog.Name);
        myDog.Eat();
        myDog.AnimalMove();
    }

    public static string Method(IVehicle v)
    {
        return v.Honk();
    }
}
