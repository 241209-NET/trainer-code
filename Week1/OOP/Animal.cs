namespace OOP;

public abstract class Animal
{
    public string Name { get;set; } = "";
    public string Color { get;set; } = "";

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public abstract void AnimalMove();
}