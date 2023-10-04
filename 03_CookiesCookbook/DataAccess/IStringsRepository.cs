namespace _03_CookiesCookbook.Recipes.DataAccess;

public interface IStringsRepository
{
    List<string> Read(string filePath);

    void Write(
        string filePath, List<string> names);
}