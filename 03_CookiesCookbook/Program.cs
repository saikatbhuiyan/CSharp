using System.Text.Json;
using _03_CookiesCookbook.App;
using _03_CookiesCookbook.Recipes;
using _03_CookiesCookbook.Recipes.DataAccess;
using _03_CookiesCookbook.Recipes.FileAccess;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository =
    Format == FileFormat.Json ? new StringsJsonRepository() : new StringsTextualRepository();

const string FileName = "recipes";

var fileMetaData = new FileMetadata(FileName, Format);

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(stringsRepository, ingredientsRegister), 
    new RecipesConsoleUserInteraction(ingredientsRegister));

cookiesRecipesApp.Run(fileMetaData.ToPath());
