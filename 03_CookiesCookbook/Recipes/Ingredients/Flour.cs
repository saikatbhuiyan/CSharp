namespace _03_CookiesCookbook.Recipes;

public abstract class Flour : Ingredient
{
    public override string PreparationInstructions =>
        $"Sieve. {base.PreparationInstructions}";
}