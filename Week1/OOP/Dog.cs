namespace OOP;

public class Dog : Animal
{
    public override void AnimalMove()
    {
        Console.WriteLine($"{Name} is walk");
    }
}