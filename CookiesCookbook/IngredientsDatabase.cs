using CookiesCookbook.Models;

namespace CookiesCookbook;

public class IngredientsDatabase
{
    public List<Ingredient> Ingredients { get; }

    public IngredientsDatabase()
    {
        Ingredients = new List<Ingredient>()
        {
            new Butter(),
            new Cardamom(),
            new Chocolate(),
            new Cinnamon(),
            new CocoaPowder(),
            new CoconutFlour(),
            new Sugar(),
            new WheatFlour()
        };
    }

    public void WriteIngridients()
    {
        foreach (var item in Ingredients)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
    
