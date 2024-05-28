//using CookiesCookbook;
//using CookiesCookbook.Models;
//using CookiesCookbook.UserCommunication;

//var config = new AppConfig();
//string path = new CookBookFilePathBuilder().BuildFilePath(config);

//IngredientsDatabase ingredientsDatabase = new IngredientsDatabase();
//RecipesDatabase recipesDatabase = new RecipesDatabase();
//Recipe recipe = new Recipe();
//JsonRepository jsonRepository = new JsonRepository();

//Console.WriteLine("Create a new cookie recipe! Availate ingredients are: ");

//ingredientsDatabase.WriteIngridients();

//recipe.Ingredients = ConsoleReader.ReadIngredientsList(ingredientsDatabase);

//if(recipe.Ingredients.Count > 0)
//{
//    recipesDatabase.Recipes.Add(recipe);

//    Console.WriteLine("Recipe added");
//    Console.WriteLine(recipe.ToString());
//}

//jsonRepository.WriteJson(recipesDatabase.Recipes, path);



