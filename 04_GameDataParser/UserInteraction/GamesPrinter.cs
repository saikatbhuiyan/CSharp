using _04_GameDataParser.Model;

namespace _04_GameDataParser.UserInteraction;

public class GamesPrinter : IGamesPrinter
{
    private readonly IUserInteractor _userInteractor;

    public GamesPrinter(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public void Print(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            _userInteractor.PrintMessage(Environment.NewLine + "Loaded games are:");
            foreach (var videoGame in videoGames) _userInteractor.PrintMessage(videoGame.ToString());
        }
        else
        {
            _userInteractor.PrintMessage("No found in this input file.");
        }
    }
}