﻿namespace CookiesCookbook_Te.Recipes.Ingredients
{
    public class IngredientsRegister : IIngredientsRegister
    {
        public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder(),
        new CoconutFlour()
    };

        public Ingredient GetById(int id)
        {
            var AllIngredientsWithGivenId = All
                .Where(ingredient => ingredient.Id == id);

            if(AllIngredientsWithGivenId.Count() > 1)
            {
                throw new InvalidOperationException(
                    $"More than one ingredients have ID equal to {id}.");
            }

            //if(All.Select(ingredient => ingredient.Id).Distinct().Count() != All.Count())
            //{
            //    throw new InvalidOperationException(
            //        $"Some ingredients have duplicated IDs.");
            //}
            return AllIngredientsWithGivenId.FirstOrDefault();

            //foreach (var ingredient in All)
            //{
            //    if (ingredient.Id == id)
            //    {
            //        return ingredient;
            //    }
            //}
            //return null;
        }
    }
}
