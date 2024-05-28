namespace CookiesCookbook.Models;

public class Chocolate : Ingredient
{
    public override string Name => "Chocolate";

    public override string PreparationInstructions() => "Melt in a water bath. Add to other ingredients.";
}
