using System.Text.Json;

var app = new GameDataParserApp();
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception e)
{
    Console.WriteLine(
        "Sorry! The application has experienced an unexpected error " +
        "and will have to be closed.");
    logger.Log(e);
}

public class GameDataParserApp
{
    public void Run()
    {
        var fileName = ReadValidFilePathFromUser();

        var fileContents = File.ReadAllText(fileName);

        var videoGames = DesecializeVideoGamesFrom(fileContents, fileName);

        PrintGames(videoGames);

        Console.ReadKey();
    }

    private static void PrintGames(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Loaded games are:");
            foreach (var videoGame in videoGames) Console.WriteLine(videoGame);
        }
        else
        {
            Console.WriteLine("No found in this input file.");
        }
    }

    private static List<VideoGame> DesecializeVideoGamesFrom(string fileContents, string fileName)
    {
        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
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
    }

    private static string ReadValidFilePathFromUser()
    {
        var isFileReaded = false;
        // string fileName = default;
        var fileName = default(string);

        do
        {
            Console.WriteLine("Enter the name of the file you want to read:");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("The file name can not null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The file name can not empty.");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("The file not found.");
            }
            else
            {
                isFileReaded = true;
            }
        } while (!isFileReaded);

        return fileName;
    }
}


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