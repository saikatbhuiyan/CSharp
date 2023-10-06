using _04_GameDataParser.Model;

namespace _04_GameDataParser.DataAccess;

public interface IVideoGamesDeserializer
{
    List<VideoGame> DeserializeFrom(string fileName, string fileContents);
}