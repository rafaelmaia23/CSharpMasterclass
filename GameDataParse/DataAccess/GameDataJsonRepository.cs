using GameDataParse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDataParse.DataAccess
{
    public class GameDataJsonRepository : IGameDataJsonRepository
    {
        public string Read(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public List<Game> ReadGameDataJson(string fileContents)
        {
            return JsonSerializer.Deserialize<List<Game>>(fileContents);
        }
    }
}
