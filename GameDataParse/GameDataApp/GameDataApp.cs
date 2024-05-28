using GameDataParse.DataAccess;
using GameDataParse.Models;
using GameDataParse.UserInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDataParse.GameDataApp
{    
    public class GameDataApp
    {
        private readonly IUserInteraction _consoleUserInteraction;
        private readonly IGameDataJsonRepository _gameDataJsonRepository;

        public GameDataApp(IUserInteraction consoleUserInteraction, IGameDataJsonRepository gameDataJsonRepository)
        {
            _consoleUserInteraction = consoleUserInteraction;
            _gameDataJsonRepository = gameDataJsonRepository;
        }

        public void Run()
        {
            List<Game> gameData = new();
            bool isLooping = true;
            while (isLooping)
            {
                _consoleUserInteraction.ShowMessage("Enter the name of the file you want to read:");

                var filePath = Console.ReadLine();
                string jsonContent = "";

                try
                {
                    jsonContent = _gameDataJsonRepository.Read(filePath);
                    gameData = _gameDataJsonRepository.ReadGameDataJson(jsonContent);
                    isLooping = false;

                    if (gameData.Count == 0)
                    {
                        _consoleUserInteraction.ShowMessage("No games are present in the input file.");
                    }
                    else
                    {
                        _consoleUserInteraction.ShowMessage("Loaded games are: ");
                        _consoleUserInteraction.PrintGames(gameData);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    _consoleUserInteraction.ShowMessage("File name cannot be null.");
                }
                catch (ArgumentException ex)
                {
                    _consoleUserInteraction.ShowMessage("File name cannot be empty.");
                }
                catch (FileNotFoundException ex)
                {
                    _consoleUserInteraction.ShowMessage("File not found.");
                }
                catch (JsonException ex)
                {
                    _consoleUserInteraction.ShowMessage($"JSON in the {filePath} was not in a valid format. JSON body:");
                    _consoleUserInteraction.ShowMessage(jsonContent);
                    throw ex;
                }

            }
            _consoleUserInteraction.Exit();
        }
    }
}
