using System.Text.Json;

namespace _03_CookiesCookbook.Recipes.DataAccess;

public class StringsJsonRepository : StringsRepository
{
    protected override List<string> TextToString(string fileContents)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContents);
    }
    
    protected override string StringToText(List<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }
}