namespace _03_CookiesCookbook.Recipes;

public interface IIngredientsRegister
{
    IEnumerable<Ingredient> All { get; }
    Ingredient GetById(int id);
}