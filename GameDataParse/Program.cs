using GameDataParse.DataAccess;
using GameDataParse.GameDataApp;
using GameDataParse.Logger;
using GameDataParse.Models;
using GameDataParse.UserInteraction;
using System.Net.Http.Json;
using System.Text.Json;

var consoleUserInteraction = new ConsoleUserInteraction();
var gameDataJsonRepository  = new GameDataJsonRepository();
var gameDataApp = new GameDataApp(consoleUserInteraction, gameDataJsonRepository);
var logger = new Logger();

try
{
    gameDataApp.Run();
}
catch (Exception ex)
{
    logger.LogException(ex);
    consoleUserInteraction.ShowMessage("Sorry! The application has experienced an unexpected error and will have to be closed.");
    consoleUserInteraction.Exit();
}




