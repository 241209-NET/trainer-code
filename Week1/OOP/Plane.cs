namespace OOP;

public class Plane : Animal, IVehicle, ICrashable
{
    public bool IsAuto { get; set; } = true;
    public double Speed { get; set; } = 500.0;
    public double MPG { get; set; } = 5.6;
    public bool IsTotaled { get; set; } = false;

    public string Honk()
    {
        return "Plane";
    }

    public override void AnimalMove(){}

    public double Move()
    {
        throw new NotImplementedException();
    }

    public void Destroy()
    {
        Console.WriteLine("Boom, fireball, whoosh");
    }
}