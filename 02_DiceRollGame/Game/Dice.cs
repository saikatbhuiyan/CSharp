namespace _02_DiceRollGame.Game;

public class Dice
{
    private readonly Random _random;
    private const int SideCount = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1, SideCount + 1);
}