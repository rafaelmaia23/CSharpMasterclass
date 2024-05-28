using CookiesCookbook_Te.Recipes.Ingredients;
using CookiesCookbook_Te.Recipes;

namespace CookiesCookbook_Te.App
{
    public interface IRecipesUserInteraction
    {
        void ShowMessage(string message);
        void Exit();
        void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
        void PromptToCreateRecipe();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
    }
}
