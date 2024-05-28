namespace CookiesCookbook.Models;

public class Recipe
{
    public List<Ingredient> Ingredients { get; set; }

    public Recipe()
    {
        Ingredients = new List<Ingredient>();
    }

    public override string ToString()
    {
        string result = string.Empty;
        string Separator = Environment.NewLine;
        foreach (var item in Ingredients)
        {
            result += $"{item.Name}. {item.PreparationInstructions()}{Separator}";
        }
        return result;
    }
}
