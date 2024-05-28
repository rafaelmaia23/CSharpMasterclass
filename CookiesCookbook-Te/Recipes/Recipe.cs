using CookiesCookbook_Te.Recipes.Ingredients;

namespace CookiesCookbook_Te.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            var steps = Ingredients
                .Select(ingredient =>
                    $"{ingredient.Name}. {ingredient.PreparationInstructions}");

            return string.Join( Environment.NewLine, steps );


            //--------------my----------
            //return string.Join(
            //    Environment.NewLine,
            //    Ingredients
            //        .Select(ingredient => $"{ingredient.Name}. {ingredient.PreparationInstructions}")
            //        .ToList());


            //var steps = new List<string>();
            //foreach(var ingredient in Ingredients)
            //{
            //    steps.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
            //}
            //return string.Join(Environment.NewLine, steps);
        }
    }
}
