namespace OOP;

public interface IVehicle
{
    bool IsAuto { get;set; }
    double Speed { get;set; }
    double MPG { get;set; }

    double Move();
    string Honk();
}