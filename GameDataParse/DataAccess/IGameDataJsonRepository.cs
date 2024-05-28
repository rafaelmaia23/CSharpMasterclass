using GameDataParse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParse.DataAccess
{
    public interface IGameDataJsonRepository
    {
        string Read(string filePath);
        List<Game> ReadGameDataJson(string jsonFile);
    }
}
