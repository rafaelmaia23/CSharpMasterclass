using CookiesCookbook.Models;

namespace CookiesCookbook.UserCommunication;

public static class ConsoleReader
{
    public static List<Ingredient> ReadIngredientsList(IngredientsDatabase ingredientsDatabase)
    {
        List<Ingredient> result = new List<Ingredient>();
        int parseResult;
        bool parseSuccessfully;
        do
        {
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
            parseSuccessfully = int.TryParse(Console.ReadLine(), out parseResult);
            if (parseSuccessfully)
            {
                if (!(parseResult > 0 && parseResult <= ingredientsDatabase.Ingredients.Count))
                {
                    continue;
                }
                result.Add(ingredientsDatabase.Ingredients[parseResult - 1]);
            }
        }
        while (parseSuccessfully);
        return result;
    }
}
