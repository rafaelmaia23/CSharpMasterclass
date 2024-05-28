using CookiesCookbook_Te.App;
using CookiesCookbook_Te.DataAccess;
using CookiesCookbook_Te.FileAccess;
using CookiesCookbook_Te.Recipes;
using CookiesCookbook_Te.Recipes.Ingredients;

const FileFormat Format = FileFormat.Txt;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetadata(FileName, Format); 

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(
        stringsRepository,
        ingredientsRegister), 
    new RecipesConsoleUserInteraction(
        ingredientsRegister));

cookiesRecipesApp.Run(fileMetadata.ToPath());