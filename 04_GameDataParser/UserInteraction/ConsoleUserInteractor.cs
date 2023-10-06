namespace _04_GameDataParser.UserInteraction;

public class ConsoleUserInteractor : IUserInteractor
{
    public string ReadValidFilePath()
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

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintError(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }
}
