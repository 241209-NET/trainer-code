namespace Serialization;

public class Movie
{
    private string _name = "";

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public string Release { get;set; } = "1994";
    public int Copies { get;set; } = 0;
    public int Price { get;set; } = 10;

    public Movie(){}

    public Movie(string name)
    {
        Name = name;
    }

    public int TotalPrice()
    {
        return Copies * Price;
    }

    public static string FavMovie()
    {
        return "Abraham Lincoln: Vampire Hunter";
    }
}