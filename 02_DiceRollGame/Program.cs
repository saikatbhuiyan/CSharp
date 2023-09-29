using _02_DiceRollGame.Game;

var random = new Random();
int playAgain;

do
{ 
    var dice = new Dice(random);
    var guessingGame = new GuessingGame(dice);

    GameResult gameResult = guessingGame.Play();
    GuessingGame.PrintResult(gameResult);
    Console.WriteLine("Enter 1 for play again or any key for exit!");
    int.TryParse(Console.ReadLine(), out playAgain);
} while (playAgain == 1);


/*
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);
*/

Console.ReadKey();

