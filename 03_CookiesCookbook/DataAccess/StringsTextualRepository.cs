namespace _03_CookiesCookbook.Recipes.DataAccess;

public class StringsTextualRepository : StringsRepository
{
    private static readonly string Separator = Environment.NewLine;
    protected override List<string> TextToString(string fileContents)
    {
        return fileContents.Split(Separator).ToList();
    }
    
    protected override string StringToText(List<string> strings)
    {
        return string.Join(Separator, strings);
    }
}