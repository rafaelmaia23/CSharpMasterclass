using GameDataParse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParse.UserInteraction
{
    public interface IUserInteraction
    {
        void ShowMessage(string message);
        void PrintGames(List<Game> gameData);
        void Exit();

    }
}
