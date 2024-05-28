using CookiesCookbook.Models;

namespace CookiesCookbook;

public class RecipesDatabase
{
    public List<Recipe> Recipes { get; set; }

    public RecipesDatabase()
    {
        Recipes = new List<Recipe>();
    }
}
