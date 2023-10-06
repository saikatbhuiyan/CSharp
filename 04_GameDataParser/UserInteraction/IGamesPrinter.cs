using _04_GameDataParser.Model;

namespace _04_GameDataParser.UserInteraction;

public interface IGamesPrinter
{
    void Print(List<VideoGame> videoGames);
}