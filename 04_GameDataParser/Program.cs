using System.Text.Json;

var isFileReaded = false;
// string fileContents = default;
var fileContents = default(string);
var fileName = default(string);

do
{
    try
    {
        Console.WriteLine("Enter the name of the file you want to read:");
        fileName = Console.ReadLine();
        fileContents = File.ReadAllText(fileName);
        isFileReaded = true;
    }
    catch (ArgumentNullException e)
    {
        Console.WriteLine("The file name can not null.");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine("The file name can not empty.");
    }
    catch (FileNotFoundException e)
    {
        Console.WriteLine("The file not found.");
    }
} while (!isFileReaded);


List<VideoGame> videoGames = default;

try
{
    videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
}
catch (JsonException e)
{
    var originalColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"JSON in {fileName} file was not " + $"in a valid format. JSON body:");
    Console.WriteLine(fileContents);
    Console.ForegroundColor = originalColor;
    throw new JsonException($"{e.Message} The file is: {fileName}", e);
}

if (videoGames.Count > 0)
{
    Console.WriteLine();
    Console.WriteLine("Loaded games are:");
    foreach (var videoGame in videoGames) Console.WriteLine(videoGame);
}

Console.ReadKey();

public class VideoGame
{
    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }

    public override string ToString()
    {
        return $"{Title}, released in {ReleaseYear}, rating: {Rating}";
    }
}