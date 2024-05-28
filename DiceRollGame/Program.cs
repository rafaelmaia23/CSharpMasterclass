using DiceRollGame.Game;
using DiceRollGame.UserCommunication;

var random = new Random();
var dice = new Dice(random);
var consoleCommunication = new ConsoleUserCommunication();
var guessingGame = new GuessingGame(dice, consoleCommunication);

GameResult gameResult = guessingGame.Play();
guessingGame.PrintResult(gameResult);