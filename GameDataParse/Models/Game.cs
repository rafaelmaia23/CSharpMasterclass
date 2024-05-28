using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParse.Models
{
    public class Game
    {
        public string? Title { get; set; }
        public short ReleaseYear { get; set; }
        public float Rating { get; set; }

        public string Description() => $"{Title}, released in {ReleaseYear}, rating: {Rating}";
    }
}
