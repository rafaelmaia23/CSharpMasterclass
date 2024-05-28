using GameDataParse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParse.UserInteraction
{
    public class ConsoleUserInteraction : IUserInteraction
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintGames(List<Game> gameData)
        {
            foreach (Game game in gameData)
            {
                ShowMessage(game.Description());
            }
        }

        public void Exit()
        {
            ShowMessage("Press any key to close.");
        }
    }
}
