namespace ExampleProject.APP;

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