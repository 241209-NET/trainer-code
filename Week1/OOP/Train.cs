namespace OOP;

public class Train : IVehicle
{
    public bool IsAuto { get; set; }
    public double Speed { get; set; }
    public double MPG { get; set; }

    public string Honk()
    {
        return "Choo choo";
    }

    public double Move()
    {
        throw new NotImplementedException();
    }
}