namespace _03_CookiesCookbook.Recipes;

public abstract class Spice : Ingredient
{
    public override string PreparationInstructions =>
        $"Take half a teaspoon. {base.PreparationInstructions}";
}