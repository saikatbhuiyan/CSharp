
using System.Text.Json;

Console.WriteLine("Enter the name of the file you want to read:");
var fileName = Console.ReadLine();

var fileContents = File.ReadAllText(fileName);

var videoGames = JsonSerializer.Deserialize<List<VideoGames>>(fileContents);

if (videoGames.Count > 0)
{
    Console.WriteLine();
    Console.WriteLine("Loaded games are:");
    foreach (var videoGame in videoGames)
    {
        Console.WriteLine(videoGame);
    }
    
}

Console.ReadKey();

public class VideoGames
{
    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }

    public override string ToString() => $"{Title}, released in {ReleaseYear}, rating: {Rating}";
}