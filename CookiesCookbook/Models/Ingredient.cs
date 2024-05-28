namespace CookiesCookbook.Models;

public abstract class Ingredient
{
    public int ID { get; }
    public abstract string Name { get; }
    public static int Count { get; set; } = 1;
    public Ingredient()
    { 
        ID = Count;
        ++Count;
    }
    public abstract string PreparationInstructions();

    public override string ToString() => $"{ID}. {Name}";
}
