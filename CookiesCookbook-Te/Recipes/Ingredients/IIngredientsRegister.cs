namespace CookiesCookbook_Te.Recipes.Ingredients
{
    public interface IIngredientsRegister
    {
        IEnumerable<Ingredient> All { get; }

        Ingredient GetById(int id);
    }
}
